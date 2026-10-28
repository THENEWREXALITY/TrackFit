using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackFit.UserControls
{
    public partial class UC_Goal : UserControl
    {

        string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyAppFolder");
        public static string loggedInUsername { get; private set; }
        public UC_Goal()
        {
            InitializeComponent();

            
        }

        private void UC_Goal_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
