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
    public partial class UC_GoalSetter : UserControl
    {

        private readonly string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        private readonly string userDataFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        
            
        private int totalCaloriesTarget;
        public UC_GoalSetter()
        {

            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            

        

            if (!int.TryParse(txtInfo1.Text, out int calorie))
            {
                MessageBox.Show("Please enter a valid number for calories.");
                return;
            }

            if (!int.TryParse(txtInfo2.Text, out int time))
            {
                MessageBox.Show("Please enter a valid number for time.");
                return;
            }
            
            string goal = cmbGoals.Text;

            if (string.IsNullOrEmpty(goal))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!Enum.TryParse(goal, true, out Goal goaltype))
            {
                MessageBox.Show("Invalid goal. Please enter a valid goal.");
                return;
            }
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            SaveUserData(goal, time, (Goal)calorie);


            ClearFields();
        }

        private void SaveUserData(string fullName, int age, Goal goal)
        {


            // Format user data and append to the file
            string userData = $"{fullName},{age}\n";
            File.AppendAllText(userDataFile, userData);
        }

        private void ClearFields()
        {
            txtInfo1.Text = "";
            txtInfo2.Text = "";
            cmbGoals.Text = "";

        }

        private void SaveUserData(Goal goal, int time, int calorie)
        {
            string userFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"workoutdata.txt");

            using (StreamWriter writer = new StreamWriter(userFilePath, append: true))
            {
                writer.WriteLine($"Goal:{goal}");
                writer.WriteLine($"Calories:{calorie}");
                writer.WriteLine($"Time:{time}");
            }
        }

        public void SetTotalCaloriesTarget(int target)
        {
            totalCaloriesTarget = target;
            // Optionally display the target in a TextBox within this control if desired
            cmbGoals.Text = totalCaloriesTarget.ToString();
        }
    }
}
