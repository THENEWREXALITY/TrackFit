using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;

namespace TrackFit
{
    public partial class SignUpForm : Form
    {

        private readonly string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        
        public SignUpForm()
        {
            InitializeComponent();

            
            CreateUserDataFolder();

            txtPassword.PasswordChar = '*';

        }

        private void lnkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current form (LoginForm)
            this.Hide();

            // Show the SignUpForm
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string userFilePath = Path.Combine(userDataFolder, $"{username}.txt");
            string userFile = Path.Combine(userDataFolder, $"{username}_{password}.txt");

            

            if (IsValidUsername(username) && IsValidPassword(password))
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                using (FileStream fs = File.Create(userFile))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine($"Username: {username}");
                        writer.WriteLine($"Password: {password}");
                    }
                }

                MessageBox.Show("Login Sucessful.");
                UserInfo userInfo = new UserInfo();
                userInfo.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        

        private void ClearFields()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            
        }

        

        private void CreateUserDataFolder()
        {
            if (!Directory.Exists(userDataFolder))
            {
                Directory.CreateDirectory(userDataFolder);
            }
        }

        private bool IsValidUsername(string username)
        {
            return username.Length <= 12 && Regex.IsMatch(username, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{1,12}$");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length <= 12 && Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{1,12}$");
        }
    }
}
