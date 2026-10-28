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
using TrackFit.UserControls;

namespace TrackFit
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        

        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UserPanel.Controls.Clear();
            UserPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            UC_UserInfo uc = new UC_UserInfo();
            addUserControl(uc);
        }
    }
}
