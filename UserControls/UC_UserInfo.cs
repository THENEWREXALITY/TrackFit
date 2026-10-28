using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrackFit.UserControls
{
    public partial class UC_UserInfo : UserControl
    {

        private readonly string userDataFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit", "LoginInfo.txt");
        public UC_UserInfo()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {

            string fullname = txtInfo1.Text + txtInfo2.Text;
            int age = int.Parse(txtInfo3.Text);

            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            UC_GoalSetter ucOther = new UC_GoalSetter();
            UserInfo parentForm = (UserInfo)this.ParentForm;
            parentForm.addUserControl(ucOther);
            SaveUserData(fullname, age);

            ClearFields();


        }

        private void SaveUserData(string fullName, int age)
        {
  

            // Format user data and append to the file
            string userData = $"{fullName},{age}\n";
            File.AppendAllText(userDataFile, userData);
        }

        private void ClearFields()
        {
            txtInfo1.Text = "";
            txtInfo2.Text = "";
            txtInfo3.Text = "";
            
        }
    }
}
