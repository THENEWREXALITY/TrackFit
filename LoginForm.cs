using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackFit
{

    public partial class LoginForm : Form
    {

        private readonly string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        private readonly string userDataFile;
        public LoginForm()
        {
            InitializeComponent();

            userDataFile = Path.Combine(userDataFolder, "LoginInfo.txt");
            txtPassWord.PasswordChar = '*';
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the current form (SignUpForm)
            this.Hide();

            // Show the LoginForm
            SignUpForm signupForm = new SignUpForm();
            signupForm.ShowDialog();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            string userFile = Path.Combine(userDataFolder, $"{username}_{password}.txt");

            if (File.Exists(userFile))
            {
                MessageBox.Show("Login Sucessful!");
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                LoadUserData(username);
                UserSession.LoggedInUsername = txtUserName.Text;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }

        public static class UserSession
        {
            public static string LoggedInUsername { get; set; }
        }

        private void LoadUserData(string username)
        {
            string userFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"{username}_workoutdata.txt");

            if (File.Exists(userFilePath))
            {
                string[] lines = File.ReadAllLines(userFilePath);

                
                if (lines.Length > 0)
                {
                    
                    Enum.TryParse(lines[0], out Goal userGoal);
                    
                }

                
                if (lines.Length > 1)
                {
                    
                    foreach (var line in lines.Skip(1))
                    {
                        var parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string workoutType = parts[0];
                            int calories = int.Parse(parts[1]);
                        }
                    }
                }
            }
        }


    }
}

