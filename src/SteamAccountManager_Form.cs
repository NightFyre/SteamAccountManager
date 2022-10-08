using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager
{
    public partial class NightFyre_Frameworks : Form
    {

        /// DATABASE PATH WILL BE IN THE EXECUTING DIRECTORY
        string dbPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Database.txt");

        /// CUSTOM DATABSE PATH
        //string dbPath = @"";      // Example @"C:\Private\database.txt"

        struct UserAccounts
        {
            public UserAccounts(string username, string password)
            {
                user = username;
                pass = password;
            }
            public string user { get; }
            public string pass { get; }
        }

        List<UserAccounts> AccountList = new List<UserAccounts>();

        public NightFyre_Frameworks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// INITIALIZE PROCESS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NightFyre_Frameworks_Load(object sender, EventArgs e)
        {
            /// CHECK IF DATABSE FILE EXISTS
            if (!File.Exists(dbPath))
            {
                StreamWriter sw = File.CreateText(dbPath);
                sw.Flush();
                sw.Dispose();
                return;
            }

            /// READ DATABASE CONTENTS
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            /// CHECK IF FIRST LINE IS EMPTY (prevents crash)
            if (lines.Count == 0 || lines[0] == "")
            {
                StreamWriter sw = File.CreateText(dbPath);
                sw.Flush();
                sw.Dispose();
                return;
            }

            /// OBTAINS ACCOUNTS AND POPULATES COMBOBOX
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                UserAccounts newUser = new UserAccounts(entries[0], entries[1]);
                Accounts_ComboBox.Items.Add(entries[0]);
                AccountList.Add(newUser);
            }
        }

        private void NewUserAccount_Button_Click(object sender, EventArgs e)
        {
            /// RETURN IF TEXTBOX ENTRIES ARE NULL
            if (Username_Textbox.Text == "" || Password_Textbox.Text == "")
            {
                // Clear textbox entries
                Username_Textbox.Clear();
                Password_Textbox.Clear();
                return;
            }

            List<string> lines = File.ReadAllLines(dbPath).ToList();                        //  Read Contents
            var User = new UserAccounts(Username_Textbox.Text, Password_Textbox.Text);      //  Initialize User Variable
            AccountList.Add(User);                                                          //  Add User to Account List
            lines.Add(User.user + "," + User.pass);                                         //  Parse String with Seperator
            File.WriteAllLines(dbPath, lines);                                              //  Write contents to file

            /// CLEAR BUFFERS
            Username_Textbox.Clear();
            Password_Textbox.Clear();
            Accounts_ComboBox.Items.Clear();

            /// ADD ACCOUNT TO DATABASE
            foreach (UserAccounts v in AccountList)
                Accounts_ComboBox.Items.Add(v.user);
        }

        private void UserLogin_Button_Click(object sender, EventArgs e)
        {
            /// CHECK IF STEAM IS RUNNING
            foreach (var process in Process.GetProcessesByName("steam"))
                process.Kill(); //  Kill Process
            
            ProcessStartInfo startInfo = new ProcessStartInfo();                                                                                                        //  Initialize Variable
            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");                                              //  Get Process Information to Start
            startInfo.Arguments = $" -noreactlogin -login {AccountList[Accounts_ComboBox.SelectedIndex].user} {AccountList[Accounts_ComboBox.SelectedIndex].pass}";     //  Assign Process Launch Arguments
            Process.Start(startInfo);                                                                                                                                   //  Launch Process w/ Login Credentials & Bypass New Login UI
        }

        private void UserLogout_Button_Click(object sender, EventArgs e)
        {
            /// CHECK IF STEAM IS RUNNING
            foreach (var process in Process.GetProcessesByName("steam"))
                process.Kill(); //  Kill Process

            ProcessStartInfo startInfo = new ProcessStartInfo();                                                                                                        //  Initialize Variable
            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");                                              //  Get Process Information to Start
            startInfo.Arguments = $" -noreactlogin -logoff ";                                                                                                           //  Assign Process Launch Arguments
            Process.Start(startInfo);                                                                                                                                   //  Launch Process w/ Loggoff Command & Bypass New Login UI
        }
    }
}
