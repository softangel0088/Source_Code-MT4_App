using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class SQLiteWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SQLiteConnection sql_con;
        public SQLiteCommand sql_cmd;
        private System.Object locker = new System.Object();

        public SQLiteWrapper() { }

        public void CreateFile(string file_name)
        {
            SQLiteConnection.CreateFile(file_name);
        }

        public void Init()
        {
            string dbName = Settings.dbFile;

            try
            {
                if (!File.Exists(dbName))
                {
                    CreateFile(dbName);
                    CreatConnection(dbName);
                    Open();

                    //create table
                    ExecuteNonQuery("Create table account (clientId INTEGER(0), name varchar(255), server_name1 varchar(255), server_name2 varchar(255), userId1 varchar(255), password1 varchar(255), userId2 varchar(255), password2 varchar(255), email varchar(255), email_password varchar(255), " +
                        "money_shift_flag INTEGER(0), money_shift_amount INTEGER(0), pamm INTEGER(0), margin_alert_amount double(0), margin_call_amount double(0), notification_amount double(0), " +
                        "phone_number varchar(255), swapfree_flag1 INTEGER(0), swapfree_flag2 INTEGER(0), stop_level1 double(0), stop_level2 double(0))");

                    ExecuteNonQuery("create table SLTP (ticket INTEGER(0), SLTP DOUBLE)");
                    ExecuteNonQuery("create table LICENSE (number varchar(255), date varchar(255))");
                    ExecuteNonQuery("create table SWAP_START_DATE (date varchar(255))");
                    ExecuteNonQuery("create table PENDINGORDER (clientId INTEGER(0), symbolId INTEGER(0), lots double(0), stick double(0))");
                    ExecuteNonQuery("create table settings (moneyshift INTEGER(0), margincall INTEGER(0), phonenotify INTEGER(0))");
                }
                else
                {
                    CreatConnection(dbName);
                    Open();
                    add_additional_fields();
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to init: " + ex.ToString());
            }
        }

        private void add_additional_fields()
        {
            try
            {
                if (!server_name_exist())
                {
                    ExecuteNonQuery("alter table account add column server_name1 varchar(255)");
                    ExecuteNonQuery("alter table account add column server_name2 varchar(255)");
                }

                if (!swapfree_flag_exist())
                {
                    ExecuteNonQuery("alter table account add column swapfree_flag1 INTEGER(0)");
                    ExecuteNonQuery("alter table account add column swapfree_flag2 INTEGER(0)");
                }

                if (!hedge_flag_exist())
                {
                    ExecuteNonQuery("alter table account add column hedge_flag1 INTEGER(0)");
                    ExecuteNonQuery("alter table account add column hedge_flag2 INTEGER(0)");
                }

                if (!stop_level_exist())
                {
                    ExecuteNonQuery("alter table account add column stop_level1 double(0)");
                    ExecuteNonQuery("alter table account add column stop_level2 double(0)");
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Add server name failed: " + ex.ToString());
            }
        }

        private bool server_name_exist()
        {
            DataTable dt = GetDataTable("account", "");
            if (dt.Columns.IndexOf("server_name1") >= 0)
                return true;
            return false;
        }

        private bool hedge_flag_exist()
        {
            DataTable dt = GetDataTable("account", "");
            if (dt.Columns.IndexOf("hedge_flag1") >= 0)
                return true;
            return false;
        }

        private bool swapfree_flag_exist()
        {
            DataTable dt = GetDataTable("account", "");
            if (dt.Columns.IndexOf("swapfree_flag1") >= 0)
                return true;
            return false;
        }

        private bool stop_level_exist()
        {
            DataTable dt = GetDataTable("account", "");
            if (dt.Columns.IndexOf("stop_level1") >= 0)
                return true;
            return false;
        }

        public void CreatConnection(string file_name)
        {
            try
            {
                string conn = "Data Source=" + file_name + ";Version=3;New=True;Compress=True;";
                sql_con = new SQLiteConnection(conn);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to create SQLite connection: " + ex.ToString());
            }
        }

        public void Open()
        {
            try
            {
                sql_con.Open();
                //sql_con.ChangePassword("FxFellow");
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to open SQLite connection: " + ex.ToString());
            }
        }

        public void Close()
        {
            try
            {
                sql_con.Close();
                sql_con.Dispose();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to close SQLite connection: " + ex.ToString());
            }
        }

        public bool check_swap_start_date_table()
        {
            bool result = false;
            try
            {
                result = ExecuteNonQuery("SELECT 1 FROM SWAP_START_DATE LIMIT 1;");
                if (!result)
                {
                    ExecuteNonQuery("create table SWAP_START_DATE (date varchar(255))");
                }
            }
            catch (Exception)
            {
                ExecuteNonQuery("create table SWAP_START_DATE (date varchar(255))");
                result = false;
            }
            return result;
        }

        public void save_swap_start_date(string dateStr)
        {
            try
            {
                bool val = check_swap_start_date_table();
                ExecuteNonQuery("DELETE from SWAP_START_DATE WHERE 1 = 1");
                ExecuteNonQuery($"INSERT into SWAP_START_DATE(date) VALUES('{dateStr}')");
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Save swap start date failed: " + ex.ToString());
            }
        }

        public string read_swap_start_date()
        {
            try
            {
                bool val = check_swap_start_date_table();
                string query = "SELECT * from SWAP_START_DATE";
                DataTable table = ExecuteQuery(query);

                foreach (DataRow row in table.Rows)
                {
                    return row.ItemArray[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Read swap start date failed: " + ex.ToString());
            }
            return "";
        }

        public bool check_license_table()
        {
            bool result = false;
            try
            {
                result = ExecuteNonQuery("SELECT 1 FROM LICENSE LIMIT 1;");
                if (!result)
                {
                    ExecuteNonQuery("create table LICENSE (number varchar(255), date varchar(255))");
                }
            }
            catch (Exception)
            {
                ExecuteNonQuery("create table LICENSE (number varchar(255), date varchar(255))");
                result = false;
            }
            return result;
        }

        public void save_license(LicenseInfo info)
        {
            try
            {
                bool val = check_license_table();
                ExecuteNonQuery("DELETE from LICENSE WHERE 1 = 1");
                ExecuteNonQuery($"INSERT into LICENSE(number, date) VALUES('{info.number}', '{info.date}')");
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Save license failed: " + ex.ToString());
            }
        }

        public LicenseInfo read_license()
        {
            LicenseInfo info = new LicenseInfo();
            info.Init();

            try
            {
                bool val = check_license_table();
                string query = "SELECT * from LICENSE";
                DataTable table = ExecuteQuery(query);

                foreach (DataRow row in table.Rows)
                {
                    info.number = row.ItemArray[0].ToString();
                    info.date = row.ItemArray[1].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Read License failed: " + ex.ToString());
            }
            return info;
        }

        public bool check_SLTP_table()
        {
            bool result = ExecuteNonQuery("SELECT 1 FROM SLTP LIMIT 1;");
            if(!result)
            {
                ExecuteNonQuery("create table SLTP (ticket INTEGER(0), SLTP DOUBLE)");
            }
            return result;
        }

        public bool check_settings_table()
        {
            try
            {
                bool result = ExecuteNonQuery("SELECT 1 FROM settings LIMIT 1;");
                if (!result)
                {
                    ExecuteNonQuery("create table settings (moneyshift INTEGER(0), margincall INTEGER(0), phonenotify INTEGER(0))");
                }
                return result;
            }
            catch(Exception)
            {
                ExecuteNonQuery("create table settings (moneyshift INTEGER(0), margincall INTEGER(0), phonenotify INTEGER(0))");
                return false;
            }
        }

        public void check_encrypt_table()
        {
            bool result = ExecuteNonQuery("SELECT 1 FROM account_encrypt LIMIT 1;");
            if (!result)
            {
                ExecuteNonQuery("create table account_encrypt (account1 varchar(255), account2 varchar(255))");
            }
        }


        public void save_encrypt_account()
        {
            try
            {
                check_encrypt_table();
                ExecuteNonQuery("DELETE from account_encrypt WHERE 1 = 1");

                LicenseInfo info = read_license();
                SimpleAES _aes = new SimpleAES();

                DataTable dt = GetDataTable("account", "");
                int tot_num = dt.Rows.Count;

                for (int k = 0; k < tot_num; k++)
                {
                    string id_str1 = dt.Rows[k]["userId1"].ToString();
                    string id_str2 = _aes.Encrypt(info.number + "_" + id_str1);

                    //ExecuteNonQuery($"INSERT into account_encrypt(acc, SLTP) VALUES({item.Key}, {item.Value})");
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Save encrypt account failed: " + ex.ToString());
            }
        }

        public void save_SLTP(Dictionary<int, double> dict)
        {
            bool val = check_SLTP_table();
            ExecuteNonQuery("DELETE from SLTP WHERE 1 = 1");

            foreach (var item in dict)
            {
                ExecuteNonQuery($"INSERT into SLTP(ticket, SLTP) VALUES({item.Key}, {item.Value})");
            }
        }

        public Dictionary<int, double> read_SLTP()
        {
            Dictionary<int, double> result = new Dictionary<int, double>();

            try
            {
                string query = "SELECT * from SLTP";
                DataTable table = ExecuteQuery(query);

                int ticket;
                double SLTP;

                foreach (DataRow row in table.Rows)
                {
                    if(!Int32.TryParse(row.ItemArray[0].ToString(), out ticket)) ticket = 0;
                    if (!Double.TryParse(row.ItemArray[1].ToString(), out SLTP)) SLTP = 0;

                    if(ticket > 0)
                        result.Add(ticket, SLTP);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Read SLTP failed: " + ex.ToString());
            }
            return result;
        }

        public void save_settings(int moneyshift, int margincall, int phonenotify)
        {
            try
            {
                bool val = check_settings_table();
                ExecuteNonQuery("DELETE from settings WHERE 1 = 1");
                ExecuteNonQuery($"INSERT into settings(moneyshift, margincall, phonenotify) VALUES({moneyshift}, {margincall}, {phonenotify})");
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Save settings failed: " + ex.ToString());
            }
        }

        public List<int> read_settings()
        {
            List<int> settingList = new List<int>();
            int val;

            try
            {
                check_settings_table();

                string query = "SELECT * from settings";
                DataTable table = ExecuteQuery(query);

                foreach (DataRow row in table.Rows)
                {
                    if (!Int32.TryParse(row.ItemArray[0].ToString(), out val)) val = 0;
                    settingList.Add(val);
                    if (!Int32.TryParse(row.ItemArray[1].ToString(), out val)) val = 0;
                    settingList.Add(val);
                    if (!Int32.TryParse(row.ItemArray[2].ToString(), out val)) val = 0;
                    settingList.Add(val);
                    break;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Read settings failed: " + ex.ToString());
            }

            if(settingList.Count != 3)
            {
                settingList.Clear();
                settingList.Add(0);
                settingList.Add(0);
                settingList.Add(0);
            }
            return settingList;
        }

        public int search_name_userId(string keyStr)
        {
            try
            {
                string query = "SELECT clientId FROM account WHERE name LIKE '%" + keyStr + "%' OR userId1 LIKE '%" + keyStr + "%' OR userId2 LIKE '%" + keyStr + "%'";
                return get_one_result_from_query(query);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to search client(name, userID) from db: " + ex.ToString());
                return -1;
            }
        }

        public int search_name(string keyStr)
        {
            try
            {
                string query = "SELECT clientId FROM account WHERE name LIKE '%" + keyStr + "%'";
                return get_one_result_from_query(query);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to search client(name) from db: " + ex.ToString());
                return -1;
            }
        }

        public int search_userId(string keyStr)
        {
            try
            {
                string query = "SELECT clientId FROM account WHERE userId1 LIKE '%" + keyStr + "%' OR userId2 LIKE '%" + keyStr + "%'";
                return get_one_result_from_query(query);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to search client(userID) from db: " + ex.ToString());
                return -1;
            }
        }

        public int search_pamm(string keyStr)
        {
            try
            {
                string query = "SELECT clientId FROM account WHERE pamm = 1 and (name LIKE '%" + keyStr + "%' OR userId1 LIKE '%" + keyStr + "%' OR userId2 LIKE '%" + keyStr + "%')";
                return get_one_result_from_query(query);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to search client(pamm) from db: " + ex.ToString());
                return -1;
            }
        }

        public int search_moneyshift(string keyStr)
        {
            try
            {
                string query = "SELECT clientId FROM account WHERE money_shift_flag = 1 and (name LIKE '%" + keyStr + "%' OR userId1 LIKE '%" + keyStr + "%' OR userId2 LIKE '%" + keyStr + "%')";
                return get_one_result_from_query(query);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to search client(money shift) from db: " + ex.ToString());
                return -1;
            }
        }

        public int get_one_result_from_query(string query)
        {
            try
            {
                DataTable table = ExecuteQuery(query);
                if (table.Rows.Count != 1) return -1;

                string resStr = table.Rows[0].ItemArray[0].ToString();
                return Int32.Parse(resStr);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Can't execute search query: " + ex.ToString());
                return -1;
            }
        }

        public void insert_client_into_db(ClientInfo info)
        {
            SimpleAES _aes = new SimpleAES();
            try
            {
                string queryStr = "INSERT INTO account(clientId, name, server_name1, server_name2, userId1, password1, userId2, password2, email, email_password, money_shift_flag, money_shift_amount, pamm, margin_alert_amount, " +
                    "margin_call_amount, notification_amount, phone_number, swapfree_flag1, swapfree_flag2, hedge_flag1, hedge_flag2, stop_level1, stop_level2) VALUES(" +
                    info.clientId + ",'" + info.name + "', '" + info.server_name1 + "', '" + info.server_name2 + "', '" + info.userId1.ToString() + "', '" + _aes.Encrypt(info.password1) + "', '" + 
                    info.userId2.ToString() + "', '" + _aes.Encrypt(info.password2) + "', '" + info.email + "', '" + _aes.Encrypt(info.emailPassword) +
                    "', " + info.moneyShiftFlag + ", " + info.moneyShiftAmount + ", " + info.pamm + ", " + info.margin_alert_amount + ", " + info.margin_call_amount + ", " + info.free_pip_amount + ", '" + info.phone_number + "', " + 
                    info.swapfree_flag1 + ", " + info.swapfree_flag2 + ", " + info.hedge_flag1 + ", " + info.hedge_flag2 + ", " + info.stop_level1 + ", " + info.stop_level2 + ")";

                ExecuteQuery(queryStr);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't save into db: " + ex.ToString());
            }
        }

        public void update_db(ClientInfo info)
        {
            try
            {
                string queryStr = "update account set money_shift_flag = " + info.moneyShiftFlag + ", money_shift_amount = " + info.moneyShiftAmount + ", pamm = " + info.pamm + ", swapfree_flag1 = " + info.swapfree_flag1 + ", swapfree_flag2 = " + info.swapfree_flag2 +
                    ", hedge_flag1 = " + info.hedge_flag1 + ", hedge_flag2 = " + info.hedge_flag2 + ", stop_level1 = " + info.stop_level1 + ", stop_level2 = " + info.stop_level2 +
                    ", margin_alert_amount = " + info.margin_alert_amount + ", " + "margin_call_amount = " + info.margin_call_amount + ", notification_amount = " + info.free_pip_amount + ", phone_number = '" + info.phone_number +"' where clientId = " + info.clientId;
                ExecuteQuery(queryStr);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Update db failed: " + ex.ToString());
            }
        }

        public void delete_one_client(ClientInfo info)
        {
            try
            {
                string queryStr = "delete from account where clientId = " + info.clientId;
                ExecuteQuery(queryStr);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Delete one client from db failed: " + ex.ToString());
            }
        }

        public bool ExecuteNonQuery(string txtQuery)
        {
            try
            {
                lock (locker)
                {
                    sql_cmd = sql_con.CreateCommand();
                    sql_cmd.CommandText = txtQuery;
                    sql_cmd.ExecuteNonQuery();
                    sql_cmd.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to execute SQLite query: " + txtQuery + " : " + ex.ToString());
                return false;
            }
        }

        public DataTable ExecuteQuery(string txtQuery)
        {
            try
            {
                lock (locker)
                {
                    DataTable dt = new DataTable();
                    sql_cmd = sql_con.CreateCommand();
                    SQLiteDataAdapter DB = new SQLiteDataAdapter(txtQuery, sql_con);
                    DB.SelectCommand.CommandType = CommandType.Text;
                    DB.Fill(dt);
                    sql_cmd.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to execute SQLite query: " + txtQuery + " : " + ex.ToString());
            }
            return null;
        }

        public DataTable GetDataTable(string tablename, string where)
        {
            try
            {
                DataTable DT = new DataTable();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = string.Format("SELECT * FROM {0} {1}", tablename, where);
                var adapter = new SQLiteDataAdapter(sql_cmd);
                adapter.AcceptChangesDuringFill = false;
                adapter.Fill(DT);

                DT.TableName = tablename;
                foreach (DataRow row in DT.Rows)
                {
                    row.AcceptChanges();
                }
                return DT;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to execute SQLite query: " + ex.ToString());
            }
            return null;
        }
    }
}
