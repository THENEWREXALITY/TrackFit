using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackFit.UserControls;

namespace TrackFit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomePanel.Controls.Clear();
            HomePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void ActivityButton_Click(object sender, EventArgs e)
        {
            UC_Activities uc = new UC_Activities();
            addUserControl(uc);
        }

        private void SignoutButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void GoalButton_Click(object sender, EventArgs e)
        {
            UC_Goal uc = new UC_Goal();
            addUserControl(uc);
        }

        
    }
}
