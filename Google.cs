using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using Cookie = System.Net.Cookie;
using Size = System.Drawing.Size;

namespace FXFellowDashboard
{
    public class Google : IGoogle
    {
        public MoneyShiftParam m_param;
        public Google(MoneyShiftParam param)
        {
            m_param = param;

            int _ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int _ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            // calc layout
            m_size.Width = 1024;
            m_size.Height = 800;

            m_location.X = 0; // _ScreenWidth - m_size.Width;
            m_location.Y = 0;
        }

        public async Task<Result> workflow()
        {
            try
            {
                if (!Start())
                {
                    return new Result(false, "Chrome failed start. Check the chromedriver.exe version.");
                }

                while (Driver.WindowHandles.Count > 1)
                {
                    Driver.SwitchTo().Window(Driver.WindowHandles.Last());
                    Driver.Close();
                }
                Driver.SwitchTo().Window(Driver.WindowHandles.First());

                if (!await login())
                {
                    return new Result(false, "Login failed. Check the credentials.");
                }

                if (!await check_account())
                {
                    return new Result(false, "Accounts mismatch.");
                }

                if (!await check_status())
                {
                    return new Result(false, "Pending right now. Try later.");
                }

                if (!await transfer())
                {
                    return new Result(false, "Transfer failed");
                }

                return new Result(true, "Success");
            }
            catch(Exception ex)
            {
                return new Result(false, ex.Message);
            }
        }

        public void close()
        {
            Driver.Quit();
        }
        async Task<bool> transfer()
        {
            try
            {
                await Navigate("https://www.fxfellow.com/en/client-portal/my-account/internal-transfers");
                string xpath = $"//*/select[@id='accountFrom']";
                if (!await WaitToPresent(xpath, 3000))
                {
                    Settings.Log.Error($"{m_param.src_id} select account failed");
                    return false;
                }
                set_value(xpath, m_param.src_id);
                TriggerChange(xpath);
                xpath = $"//*/select[@id='accountTo']";
                set_value(xpath, m_param.des_id);

                xpath = "//*/input[@id='amount']";
                await TryEnterText(xpath, m_param.amount.ToString());

                xpath = "//*/button[text()='Submit']";
                await TryClick(xpath);

                xpath = "//*/div[@class='alert alert-success']";
                await WaitToPresent(xpath, 10000);

                await Navigate("https://www.fxfellow.com/logout");

                //await Navigate("https://www.fxfellow.com/en/client-portal/my-account/history");
                //xpath = $"//*/b[text()='{m_param.src_id}']/../../td[7]";
                //if (await WaitToPresent(xpath, 10000))
                //{
                //    var wt = new Stopwatch();
                //    wt.Start();
                //    while (wt.ElapsedMilliseconds < 3*60000)
                //    {
                //        Driver.Navigate().Refresh();
                //        Driver.Navigate().Refresh();
                //        if (Driver.PageSource.Contains("Cancel Withdrawal/Internal Transfer"))
                //            return false;
                //        string status = get_value(xpath);
                //        if (status == "Processed")
                //            break;
                //        await TaskDelay(10000);
                //    }
                //    wt.Stop();
                //}

                //xpath = $"//*/b[text()='{m_param.des_id}']/../../td[7]";
                //if (await WaitToPresent(xpath, 10000))
                //{
                //    var wt = new Stopwatch();
                //    wt.Start();
                //    while (wt.ElapsedMilliseconds < 3*60000)
                //    {
                //        Driver.Navigate().Refresh();
                //        if (Driver.PageSource.Contains("Cancel Withdrawal/Internal Transfer"))
                //            return false;
                //        string status = get_value(xpath);
                //        if (status == "Processed")
                //            break;
                //        await TaskDelay(10000);
                //    }
                //    wt.Stop();
                //}

                return true;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Transfer failed: " + ex.ToString());
                return false;
            }
        }
        async Task<bool> check_status()
        {
            await Navigate("https://www.fxfellow.com/en/client-portal/my-account/history");
            string xpath = $"//*/b[text()='{m_param.src_id}']/../../td[7]";
            if (await WaitToPresent(xpath, 3000))
            {
                string status = get_value(xpath);
                if (status != "Processed")
                {
                    Settings.Log.Error($"{m_param.email} pending already");
                    return false;
                }
            }

            xpath = $"//*/b[text()='{m_param.des_id}']/../../td[7]";
            if (await WaitToPresent(xpath, 3000))
            {
                string status = get_value(xpath);
                if (status != "Processed")
                {
                    Settings.Log.Error($"{m_param.email} pending already");
                    return false;
                }
            }

            return true;
        }

        async Task<bool> check_account()
        {
            string xpath = $"//*/a[text()='{m_param.src_id}']";
            if (!await WaitToPresent(xpath, 3000))
            {
                Settings.Log.Error($"{m_param.src_id} account mismatch");
                return false;
            }
                
            xpath = $"//*/a[text()='{m_param.des_id}']";
            if (!await WaitToPresent(xpath, 3000))
            {
                Settings.Log.Error($"{m_param.des_id} account mismatch");
                return false;
            }
            return true;
        }

        async Task<bool> login()
        {
            try
            {
                await Navigate("https://www.fxfellow.com/en/client-portal");
                string xpath = "//*/input[@id='inlineFieldLogin']";
                if (!await WaitToPresent(xpath, 3000))
                    return false;
                await TryEnterText(xpath, m_param.email);
                xpath = "//*/input[@id='inlineFieldPassword']";
                await TryEnterText(xpath, m_param.password);
                xpath = "//*/button[text()='Login']";
                await TryClick(xpath);
                if(await WaitToUnvisable(xpath, 3000))
                {
                    Settings.Log.Info($"{m_param.email} login success");
                    return true;
                }
                else
                {
                    Settings.Log.Error($"{m_param.email} login failed");
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                Settings.Log.Error($"{m_param.email} login failed: " + ex.ToString());
                return false;
            }
        }
        
        void check_new_tab()
        {
            try
            {
                var cur = Driver.CurrentWindowHandle;
                foreach (var hnd in Driver.WindowHandles)
                {
                    Driver.SwitchTo().Window(hnd);
                    if (Driver.Url.Contains("newtab"))
                    {
                        System.Diagnostics.Debug.WriteLine($"Redundant window is found.");
                        Driver.Close();
                    }
                }
                Driver.SwitchTo().Window(cur);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Check new tab failed: " + ex.ToString());
            }
        }
    }
}
