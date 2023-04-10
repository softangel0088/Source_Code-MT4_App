using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Cookie = System.Net.Cookie;
using Size = System.Drawing.Size;
using System.Net.Http;
using Microsoft.Win32;

namespace FXFellowDashboard
{
    public class IGoogle
    {
        public object m_locker = new object();
        public int m_ID;
        public Guid m_guid;
        public object m_chr_data_dir = new object();
        public object m_selen_locker = new object();
        public string m_chr_user_data_dir = "";
        public string m_chr_extension_dir = Environment.CurrentDirectory + "\\ChromeExtension";
        public string m_creat_time;
        public ChromeDriver Driver;
        public IJavaScriptExecutor m_js;
        public CookieContainer m_cookies;
        public bool m_screenshot;
        public System.Drawing.Point m_location = new System.Drawing.Point(0, 0);
        public System.Drawing.Size m_size = new System.Drawing.Size(0, 0);
        public IEnumerable<int> PID = null;

        public string m_err_str = "##$$##$$";
        public bool m_incognito = false;
        public bool m_dis_webrtc = false;
        public bool m_dis_cache = false;
        public bool m_dis_js = false;
        public void DeleteCurrentChromeData()
        {
            try
            {
                Directory.Delete(m_chr_user_data_dir, true);
                return;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"#{m_ID} - Deleting chrome data dir failed. {ex.Message}");
            }
        }

        public async Task<bool> Navigate(string target)
        {
            try
            {
                string url = Driver.Url;
                Driver.Navigate().GoToUrl(target);
                return await WaitUrlChange(url);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Navigate failed: " + ex.ToString());
                return false;
            }
        }

        public async Task<bool> NavigateBack()
        {
            try
            {
                string url = Driver.Url;
                m_js.ExecuteScript("window.history.go(-1)");
                return await WaitUrlChange(url);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Navigateback failed: " + ex.ToString());
                return false;
            }
        }

        public void NewTab(string tabUrl)
        {
            lock (m_locker)
            {
                string newTabScript = "var d=document,a=d.createElement('a');"
                                + "a.target='_blank';a.href='{0}';"
                                + "a.innerHTML='new tab';"
                                + "d.body.appendChild(a);"
                                + "a.click();"
                                + "a.parentNode.removeChild(a);";
                if (String.IsNullOrEmpty(tabUrl))
                    tabUrl = "about:blank";

                m_js.ExecuteScript(String.Format(newTabScript, tabUrl));
            }
        }
        public bool Start()
        {
            try
            {
                lock (m_chr_data_dir)
                {
                    m_guid = Guid.NewGuid();
                    m_chr_user_data_dir = $"\\ChromeData\\selenium_{Thread.CurrentThread.ManagedThreadId}" + m_guid.ToString();
                    Directory.CreateDirectory(m_chr_user_data_dir);
                }

                System.Diagnostics.Debug.WriteLine($"#{m_ID} - Start...");
                try
                {
                    ChromeDriverService defaultService = ChromeDriverService.CreateDefaultService();
                    defaultService.HideCommandPromptWindow = true;
                    ChromeOptions chromeOptions = new ChromeOptions();
                    //if (m_incognito)
                    //{
                    //    chromeOptions.AddArguments("--incognito");
                    //}
                    //chromeOptions.AddArgument("--start-maximized");
                    //chromeOptions.AddArgument("--auth-server-whitelist");
                    //chromeOptions.AddArgument("--ignore-certificate-errors");
                    //chromeOptions.AddArgument("--ignore-ssl-errors");
                    //chromeOptions.AddArgument("--system-developer-mode");
                    //chromeOptions.AddArgument("--no-first-run");
                    //chromeOptions.AddArgument("headless");
                    chromeOptions.AddArgument("disable-gpu");
                    //chromeOptions.AddArgument("--user-data-dir=" + m_chr_user_data_dir);
                    //string randomUserAgent = GetRandomUserAgent();
                    //chromeOptions.AddArgument(string.Format("--user-agent={0}", (object)randomUserAgent));
                    //chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.Off);
                    //chromeOptions.AddArguments("--no-sandbox");
                    //chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.images", 2);
                    string chr_path = "";
                    string reg = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";
                    RegistryKey registryKey;
                    using (registryKey = Registry.LocalMachine.OpenSubKey(reg))
                    {
                        if(registryKey != null)
                            chr_path = registryKey.GetValue("Path").ToString() + @"\chrome.exe";
                    }
                    if (chr_path == "")
                    {
                        if (Environment.Is64BitOperatingSystem)
                            chr_path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
                        else
                            chr_path = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";

                        if (!System.IO.File.Exists(chr_path))
                        {
                            chr_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\Application\chrome.exe";
                        }                       
                    }

                    if (!System.IO.File.Exists(chr_path))
                    {
                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - chrome.exe Not found. Perhaps the Google Chrome browser is not installed on this computer.");
                        return false;
                    }
                    chromeOptions.BinaryLocation = chr_path;

                    try
                    {
                        Driver = new ChromeDriver(defaultService, chromeOptions);
                    }
                    catch (Exception ex)
                    {
                        Settings.Log.Error("Fail to start chrome.exe. Please make sure any other chrome windows are not opened: " + ex.ToString());
                        return false;
                    }
                    Driver.Manage().Window.Size = m_size;
                    Driver.Manage().Window.Position = m_location;

                    m_js = (IJavaScriptExecutor)Driver;
                    System.Diagnostics.Debug.WriteLine($"#{m_ID} - Successfully started.");
                    
                    System.Diagnostics.Debug.WriteLine($"#{m_ID} - Cache and cookies are cleared. ");

                    if (m_incognito == false)
                        remove_all_cookies(); //<- not necessary in incogneto mode
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"#{m_ID} - Failed to start. Exception:{ex.Message}\n{ex.StackTrace}");
                    try
                    {
                        Driver.Quit();
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - Failed to quit driver. Exception:{ex.Message}");
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"#{m_ID} - Exception occured while trying to start chrome driver. Exception:{ex.Message}");
            }
            return false;
        }

        public bool remove_all_cookies()
        {
            try
            {
                Driver.Manage().Cookies.DeleteAllCookies();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Removing history failed. {ex.Message}");
                return false;
            }
        }
        public async Task<bool> WaitUrlChange(string url, int timeout = 7000)
        {
            try
            {
                Stopwatch wt = new Stopwatch();
                wt.Start();
                while (wt.ElapsedMilliseconds < timeout)
                {
                    if (Driver.Url != url)
                        return true;
                    await TaskDelay(100);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"#{m_ID} - Failed to wait for url change. Exception:{ex.Message}");
            }
            return false;
        }

        public async Task<bool> TrySelect(By list, By optionToVerify, string textToSelect, int timeout = 5000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < timeout)
            {
                if (Driver.FindElement(optionToVerify).Text == textToSelect)
                    return true;
                Driver.FindElement(list).SendKeys(textToSelect[0].ToString());
                await TaskDelay(100);
            }
            return false;
        }

        public CookieContainer ConvertSeleniumCookieToCookieContainer(ICookieJar seleniumCookie)
        {
            CookieContainer cookieContainer = new CookieContainer();
            using (IEnumerator<OpenQA.Selenium.Cookie> enumerator = seleniumCookie.AllCookies.GetEnumerator())
            {
                while (((IEnumerator)enumerator).MoveNext())
                {
                    OpenQA.Selenium.Cookie current = enumerator.Current;
                    cookieContainer.Add(new Cookie(current.Name, current.Value, current.Path, current.Domain));
                }
            }
            return cookieContainer;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                Settings.Log.Error(ex.ToString());
                return false;
            }
        }

        public async Task<bool> WaitToVisible(string xpath, int TimeOut = 1000)
        {
            return await WaitToVisible(By.XPath(xpath), TimeOut);
        }
        public async Task<bool> WaitToVisible(By by, int TimeOut = 1000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                if (await IsElementVisible(by))
                    return true;
                Thread.Sleep(100);
            }
            return false;
        }

        public async Task<bool> WaitToUnvisable(string xpath, int TimeOut = 1000)
        {
            return await WaitToUnvisable(By.XPath(xpath), TimeOut);
        }
        public async Task<bool> WaitToUnvisable(By by, int TimeOut = 1000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                try
                {
                    if (!await IsElementVisible(by))
                        return true;
                }
                catch
                {
                    return false;
                }
                await TaskDelay(100);
            }
            return false;
        }

        public void drop_file(IWebElement target, string filePath, double offsetX = 0, double offsetY = 0)
        {
            const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;";

            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            IWebDriver driver = ((RemoteWebElement)target).WrappedDriver;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
            input.SendKeys(filePath);
        }
        public async Task<bool> node_present(string xpath, int timeout = 5000)
        {
            try
            {
                int time = 0;
                object node = null;
                string script = "(function()" +
                                    "{" +
                                        "node = document.evaluate('" + xpath + "', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;" +
                                        "if (node==null) return null;" +
                                        "return node.id;" +
                                "})()";
                while (time < timeout)
                {
                    node = m_js.ExecuteScript(script);
                    if (node != null)
                    {
                        await TaskDelay(1000);
                        return true;
                    }
                    int part = (new Random()).Next(1, 3) * 100;
                    await TaskDelay(part);
                    time += part;
                }
                return false;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Node present failed: " + ex.ToString());
                return false;
            }
        }
        public async Task<bool> WaitToPresent(string xpath, int TimeOut = 800)
        {
            return await WaitToPresent(By.XPath(xpath), TimeOut);
        }
        public async Task<bool> WaitToPresent(By by, int TimeOut = 5000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            do
            {
                try
                {
                    if (IsElementPresent(by))
                        return true;
                    await Task.Delay(100);
                }
                catch(Exception)
                {

                }
            }
            while (wt.ElapsedMilliseconds < TimeOut);
            return false;
        }

        public async Task<bool> WaitAttributeChange(string xpath, string attribute, string value, int TimeOut = 5000)
        {
            try
            {
                Stopwatch wt = new Stopwatch();
                wt.Start();
                do
                {
                    string val = Driver.FindElementByXPath(xpath).GetAttribute(attribute);
                    if (val == value)
                        return true;
                    await Task.Delay(100);
                }
                while (wt.ElapsedMilliseconds < TimeOut);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public async Task<bool> WaitAttributeChange_contain(string xpath, string attribute, string value, int TimeOut = 5000)
        {
            try
            {
                Stopwatch wt = new Stopwatch();
                wt.Start();
                do
                {
                    string val = Driver.FindElementByXPath(xpath).GetAttribute(attribute);
                    if (val.Contains(value))
                        return true;
                    await Task.Delay(100);
                }
                while (wt.ElapsedMilliseconds < TimeOut);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public async Task<By> WaitToPresent(List<By> by, int TimeOut = 1000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                using (List<By>.Enumerator enumerator = by.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        By current = enumerator.Current;
                        if (IsElementPresent(current))
                            return current;
                    }
                }
                await Task.Delay(100);
            }
            return null;
        }

        public async Task<bool> click_element(string xpath, int mode = 0, int timeout = 1000)
        {
            try
            {
                DateTime start = DateTime.Now;
                if (mode == 2) // move mouse on pixel
                {
                    string x_pos = "", y_pos = "";
                    int x = 0, y = 0;
                    while (x == 0 || y == 0)
                    {
                        if (DateTime.Now.Subtract(start).TotalMilliseconds > timeout)
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID}: Mouse click on {xpath} cancelled due to timeout.");
                            return false;
                        }
                        try
                        {
                            string script_x =
                                    "(function()" +
                                        "{" +
                                            "bodyRect = document.body.getBoundingClientRect();" +
                                            "el = document.evaluate('" + xpath + "', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;" +
                                            "el.style.setProperty('display', '');" +
                                            "elemRect = el.getBoundingClientRect();" +
                                            "return elemRect.left - bodyRect.left;" +
                                    //"return elemRect.left;" +
                                    "})()";
                            x_pos = m_js.ExecuteScript(script_x).ToString();
                            x = (int)float.Parse(x_pos);
                            string script_y =
                                    "(function()" +
                                        "{" +
                                            "bodyRect = document.body.getBoundingClientRect();" +
                                            "el = document.evaluate('" + xpath + "', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;" +
                                            "el.style.setProperty('display', '');" +
                                            "elemRect = el.getBoundingClientRect();" +
                                            "return elemRect.top - bodyRect.top;" +
                                        //"return elemRect.top;" +
                                        "})()";
                            y_pos = m_js.ExecuteScript(script_y).ToString();
                            y = (int)float.Parse(y_pos);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID}: Error occured while trying mouse click on {xpath}. {ex.Message}");
                            x = 0;
                            y = 0;
                        }
                    }

                    x += 1;
                    y += 1;

                    
                    return true;
                }
                else if (mode == 1)
                {
                    if (await WaitToPresent(xpath) == false)
                    {
                        System.Diagnostics.Debug.WriteLine($"#{m_ID}: Node not found. Mouse event(H+D+U) not sent to ({xpath})");
                        return false;
                    }
                    string script = @"(function(x) {
                    var el = document.evaluate('" + xpath + @"', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                    let hoverEvent = document.createEvent ('MouseEvents');
                    hoverEvent.initEvent ('mouseover', true, true);
                    el.dispatchEvent (hoverEvent);

                    let downEvent = document.createEvent ('MouseEvents');
                    downEvent.initEvent ('mousedown', true, true);
                    el.dispatchEvent (downEvent);

                    let upEvent = document.createEvent ('MouseEvents');
                    upEvent.initEvent ('mouseup', true, true);
                    el.dispatchEvent (upEvent);

                    let clickEvent = document.createEvent ('MouseEvents');
                    clickEvent.initEvent ('click', true, true);
                    el.dispatchEvent (clickEvent);
                    })();";

                    m_js.ExecuteScript(script);
                    Thread.Sleep(100);
                    //System.Diagnostics.Debug.WriteLine($"#{m_ID}: Mouse event(H+D+U) sent to ({xpath})");
                    return true;
                }
                else if (mode == 0)
                {
                    m_js.ExecuteScript($"document.evaluate('{xpath}', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.click()");
                    Thread.Sleep(100);
                    //System.Diagnostics.Debug.WriteLine($"#{m_ID}: Javascript click function called {xpath}");
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"#{m_ID}: Click element failed. {xpath}. {ex.Message}");
                return false;
            }
        }

        public IntPtr get_handle()
        {
            string title = String.Format("{0} - Mozilla Firefox", Driver.Title);
            var process = Process.GetProcesses()
                .FirstOrDefault(x => x.MainWindowTitle == title);
            if (process != null)
            {
                return process.MainWindowHandle;
            }
            return IntPtr.Zero;
        }
        public async Task<bool> TryClick_All(string xpath)
        {
            if (await TryClick(xpath, 0))
                return true;
            if (await TryClick(xpath, 1))
                return true;
            if (await TryClick(xpath, 2))
                return true;
            bool ret = false;
            try
            {
                m_js.ExecuteAsyncScript($"document.evaluate('{xpath}', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.click()");
                ret = true;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("TryClick_All failed: " + ex.ToString());
                ret = false;
            }

            if (ret == false)
                System.Diagnostics.Debug.WriteLine($"{m_ID} : Clicking all ways failed. {xpath}");
            return ret;
        }
        public async Task<bool> TryClick(string xpath, int mode = 0, int delay = 100)
        {
            try
            {
                TryClick(By.XPath(xpath), mode);
                await TaskDelay(delay);
                return true;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("TryClick failed: " + ex.ToString());
                return false;
            }
        }

        public bool TriggerChange(string xpath)
        {
            try
            {
                string js = @" 
                    if('createEvent' in document) {
                        var evt = document.createEvent('HTMLEvents');
                        evt.initEvent('change', false, true);
                        arguments[0].dispatchEvent(evt);
                    }
                    else
                        arguments[0].fireEvent('onchange');";
                Driver.ExecuteScript(js, ((RemoteWebDriver)Driver).FindElementByXPath(xpath));
                return true;
            }
            catch(Exception )
            {
                return false;
            }
        }
        public bool TryClick(By by, int mode = 0)
        {
            try
            {
                if (mode == 0)
                {
                    Driver.ExecuteScript("arguments[0].click('');", ((RemoteWebDriver)Driver).FindElement(by));
                }
                else if (mode == 1)
                {
                    Driver.FindElement(by).Click();
                }
                else if (mode == 2)
                {
                    Actions action = new Actions(Driver);
                    action.MoveToElement(Driver.FindElement(by)).Perform();
                    action.Click(Driver.FindElement(by)).Perform();
                }

                return true;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("TryClick failed: " + ex.ToString());
            }
            return false;
        }

        public async Task<bool> TryEnterText(string xpath, string textToEnter, string atributeToEdit = "value", int TimeOut = 10000, bool manualyEnter = false)
        {
            return await TryEnterText(By.XPath(xpath), textToEnter, atributeToEdit, TimeOut, manualyEnter);
        }
        public async Task<bool> TryEnterText(By by, string textToEnter, string atributeToEdit = "value", int TimeOut = 10000, bool manualyEnter = false)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                try
                {
                    if (IsElementPresent(by) && await IsElementVisible(by))
                    {
                        Driver.FindElement(by).SendKeys((string)Keys.Control + "a");
                        if (manualyEnter)
                            Driver.FindElement(by).SendKeys(textToEnter);
                        else
                            Driver.ExecuteScript($"arguments[0].value = '{textToEnter}';", ((RemoteWebDriver)Driver).FindElement(by));

                        for (int index = 0; index < 11; ++index)
                        {
                            if ((string)Driver.ExecuteScript("return arguments[0].value;", Driver.FindElement(by)) == textToEnter)
                            {
                                return true;
                            }
                            await TaskDelay(100);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //System.Diagnostics.Debug.WriteLine($"#{m_ID} - Failed to enter text. Exception:{ex.Message}");
                    Settings.Log.Error("TryEnterText failed: " + ex.ToString());
                    return false;
                }
                await Task.Delay(100);
            }
            return false;
        }
        public string set_value(string xpath, string val, string field = "value")
        {
            Object node = null;
            string script = "(function()" +
                                "{" +
                                    "node = document.evaluate(\"" + xpath + "\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;" +
                                    "if (node==null) return '" + m_err_str + "';" +
                                    "node." + field + "=\"" + val + "\";" +
                                    "return 'ok';" +
                            "})()";
            node = m_js.ExecuteScript(script);
            if (node != null)
                return node.ToString();
            return m_err_str;
        }

        public string set_attribute(string xpath, string val, string field = "innerText")
        {
            Object node = null;
            string script = "(function()" +
                                "{" +
                                    "node = document.evaluate(\"" + xpath + "\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;" +
                                    "if (node==null) return '" + m_err_str + "';" +
                                    "node.setAttribute('" + field + "',\"" + val + "\");" +
                                    "return 'ok';" +
                            "})()";
            node = m_js.ExecuteScript(script);
            if (node != null)
                return node.ToString();
            return m_err_str;
        }

        public string get_value(string xpath, string err = "", string field = "innerText")
        {
            try
            {
                var elem = Driver.FindElementByXPath(xpath);
                if (elem == null)
                    return err;
                return elem.GetAttribute(field);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get value failed: " + ex.ToString());
                return err;
            }
        }

        public async Task<bool> WaitToVisable(string xpath, int TimeOut = 1000)
        {
            return await WaitToVisable(By.XPath(xpath), TimeOut);
        }
        public async Task<bool> WaitToVisable(By by, int TimeOut = 1000)
        {
            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                if (await IsElementVisible(by))
                    return true;
                Thread.Sleep(100);
            }
            return false;
        }

        public async Task<bool> TryClickAndWait(string toClick, string toWait, int mode = 0, int TimeOut = 10000)
        {
            return await TryClickAndWait(By.XPath(toClick), By.XPath(toWait), mode, TimeOut);
        }
        public async Task<bool> TryClickAndWait(By toClick, By toWait, int mode = 0, int TimeOut = 10000)
        {
            if (!await WaitToPresent(toClick, 3000))
            {
                System.Diagnostics.Debug.WriteLine($"#{m_ID} - Element to be clicked is not present! mode:{mode} By: {toClick}");
                return false;
            }

            Stopwatch wt = new Stopwatch();
            wt.Start();
            while (wt.ElapsedMilliseconds < TimeOut)
            {
                try
                {
                    if (mode == 1)
                    {
                        string script = @"(function(x) {
                            var el = document.evaluate('" + toClick + @"', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                            let hoverEvent = document.createEvent ('MouseEvents');
                            hoverEvent.initEvent ('mouseover', true, true);
                            el.dispatchEvent (hoverEvent);

                            let downEvent = document.createEvent ('MouseEvents');
                            downEvent.initEvent ('mousedown', true, true);
                            el.dispatchEvent (downEvent);

                            let upEvent = document.createEvent ('MouseEvents');
                            upEvent.initEvent ('mouseup', true, true);
                            el.dispatchEvent (upEvent);

                            let clickEvent = document.createEvent ('MouseEvents');
                            clickEvent.initEvent ('click', true, true);
                            el.dispatchEvent (clickEvent);
                            })();";
                        Driver.ExecuteScript(script);
                        if (!await WaitToPresent(toWait, TimeOut))
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click failed for waiting! mode:{mode} By: {toClick}");
                            return false;
                        }
                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click success! mode:{mode} By: {toClick}");
                        return true;
                    }
                    else if (mode == 0)
                    {
                        Driver.ExecuteScript("arguments[0].click('');", Driver.FindElement(toClick));
                        if (!await WaitToPresent(toWait, TimeOut))
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click failed for waiting! mode:{mode} By: {toClick}");
                            return false;
                        }

                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click success! mode:{mode} By: {toClick}");
                        return true;
                    }
                    else if (mode == 2)
                    {
                        Driver.FindElement(toClick).Click();
                        if (!await WaitToPresent(toWait, TimeOut))
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click failed for waiting! mode:{mode} By: {toClick}");
                            return false;
                        }

                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click success! mode:{mode} By: {toClick}");
                        return true;
                    }
                    else if (mode == 3)
                    {
                        Actions action = new Actions(Driver);
                        action.MoveToElement(Driver.FindElement(toClick)).Perform();
                        action.Click(Driver.FindElement(toClick)).Perform();
                        if (!await WaitToPresent(toWait, TimeOut))
                        {
                            System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click failed for waiting! mode:{mode} By: {toClick}");
                            return false;
                        }
                        System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click success! mode:{mode} By: {toClick}");
                        return true;
                    }
                }
                catch
                {

                }
            }
            System.Diagnostics.Debug.WriteLine($"#{m_ID} - Click failed for waiting! mode:{mode} By: {toClick}");
            return false;
        }

        public async Task<bool> IsElementVisible(By by, int timeout = 0)
        {
            try
            {
                Stopwatch wt = new Stopwatch();
                wt.Start();
                do
                {
                    if (IsElementVisible(Driver.FindElement(by)))
                        return true;
                    await TaskDelay(100);
                } while (wt.ElapsedMilliseconds < timeout);
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public void Quit()
        {
            foreach (var hnd in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(hnd);
                Driver.Close();
            }
            Driver.Quit();
            Driver.Dispose();
            DeleteCurrentChromeData();
        }

        public IGoogle()
        {
        }

        public void SaveScreenshot(string screenshotName)
        {
            if (!m_screenshot)
                return;
            string path = $"screenshots/{m_ID}/screens/{Thread.CurrentThread.ManagedThreadId}_{m_creat_time}/";
            Directory.CreateDirectory(path);
            Driver.GetScreenshot().SaveAsFile(path + screenshotName);
        }

        public static void KillAllChromeDriverProcess()
        {
            System.Diagnostics.Debug.WriteLine("Killing all chrome drivers");
            
        }

        public Process FindLatestChromeProcess()
        {
            Process ret = null;
            foreach (Process process in new List<Process>((IEnumerable<Process>)Process.GetProcessesByName("chrome")))
            {
                if (ret == null || process.StartTime > ret.StartTime)
                    ret = process;
                //if (process.GetParentID() == ParantID)
            }
            return ret;
        }

        public void ClearChromeData()
        {
            try
            {
                string path = "ChromeData";
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }
            catch
            {
            }
        }

        public static string GetRandomUserAgent()
        {
            string[] strArray = new string[]
            {
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36",
                //"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36",
                "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.90 Safari/537.36",
                //"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36 OPR/43.0.2442.991",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 YaBrowser/17.10.0.2052 Yowser/2.5 Safari/537.36",
                //"Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36 OPR/43.0.2442.991",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36",
                //"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.89 Safari/537.36"
            };
            return strArray[new Random().Next(0, strArray.Length)];
        }

        public async Task TaskDelay(int delay)
        {
            await Task.Delay(delay);
        }

        public async Task RandomWait()
        {
            int delay = (new Random()).Next(1000, 3000);
            await Task.Delay(delay);
        }

        public Size GetScreenSize()
        {
            Size[] sizeArray = new Size[]
            {
                new Size(800, 600),
            };
            return sizeArray[new Random().Next(0, sizeArray.Length)];
        }

        public void show_wait_window(string msg = "Wait please...")
        {
            string js = @"
                height = 500;
                width = 400;
                leftPosition = (window.screen.width / 2) - ((width / 2) + 10);
                topPosition = (window.screen.height / 2) - ((height / 2) + 50);
                var sel_window = window.open('','Wait...','status = no,height = ' + height + ',width = ' + width + ', resizable = yes,left = '+leftPosition+',top='+topPosition+',screenX='+ leftPosition + ',screenY='+ topPosition +', toolbar=no,menubar=no,scrollbars=no,location=no,directories=no');
                sel_window.document.write('<p>" + msg + @"</p>');
            ";
            m_js.ExecuteScript(js);
        }

        public void close_last_window(string msg = "")
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles.First());
            if (msg != "")
            {
                m_js.ExecuteScript($"alert({msg});");
            }
        }
    }
}
