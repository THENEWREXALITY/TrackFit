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

namespace TrackFit.UserControls
{
    public partial class UC_Activities : UserControl
    {
        string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyAppFolder");
        
        
        private readonly string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        private readonly string userDataFile;

        private string loggedInUsername;

        public UC_Activities()
        {
            InitializeComponent();
            userDataFile = Path.Combine(userDataFolder, "LoginInfo.txt");

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public UC_Activities(string username) : this()
        {
            loggedInUsername = username;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out var workoutData))
                return;

            try
            {
                UpdateUserFile(loggedInUsername, workoutData, userDataFile);
                MessageBox.Show("Workout information updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}");
            }
        }

        private bool ValidateInputs(out Dictionary<string, int> workoutData)
        {
            workoutData = new Dictionary<string, int>();
            TextBox[] textBoxes =
            {
                txtInfo1, txtInfo2, txtInfo3, txtInfo4, txtInfo5, txtInfo6,
                txtInfo7, txtInfo8, txtInfo9, txtInfo10, txtInfo11, txtInfo12,
                txtInfo13, txtInfo14, txtInfo15, txtInfo16, txtInfo17, txtInfo18
            };
            string[] keys =
            {
                "Walking_Calories", "Walking_Steps", "Walking_Time", "Swimming_Calories",
                "Swimming_Laps", "Swimming_Time", "Running_Calories", "Running_Distance",
                "Running_Time", "Cycling_Calories", "Cycling_Distance", "Cycling_Time",
                "Yoga_Execution", "Yoga_Breaths", "Yoga_Time", "Weights_Sets",
                "Cycling_Reps", "Cycling_Time"
            };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!int.TryParse(textBoxes[i].Text, out int value))
                {
                    MessageBox.Show($"Please enter a valid number for {keys[i]}.");
                    return false;
                }
                workoutData[keys[i]] = value;
            }

            return true;
        }

        public int Exercise1Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo1.Text, out value);
                return value;
            }
        }

        public int Exercise2Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo2.Text, out value);
                return value;
            }
        }
        public int Exercise3Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo3.Text, out value);
                return value;
            }
        }

        public int Exercise4Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo4.Text, out value);
                return value;
            }
        }
        public int Exercise5Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo5.Text, out value);
                return value;
            }
        }

        public int Exercise6Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo6.Text, out value);
                return value;
            }
        }
        public int Exercise7Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo7.Text, out value);
                return value;
            }
        }

        public int Exercise8Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo8.Text, out value);
                return value;
            }
        }
        public int Exercise9Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo9.Text, out value);
                return value;
            }
        }

        public int Exercise10Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo10.Text, out value);
                return value;
            }
        }
        public int Exercise11Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo11.Text, out value);
                return value;
            }
        }

        public int Exercise12Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo12.Text, out value);
                return value;
            }
        }
        public int Exercise13Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo13.Text, out value);
                return value;
            }
        }

        public int Exercise14Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo14.Text, out value);
                return value;
            }
        }
        public int Exercise15Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo15.Text, out value);
                return value;
            }
        }

        public int Exercise16Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo16.Text, out value);
                return value;
            }
        }
        public int Exercise17Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo17.Text, out value);
                return value;
            }
        }

        public int Exercise18Value
        {
            get
            {
                int value;
                int.TryParse(txtInfo18.Text, out value);
                return value;
            }
        }


        

        private void UpdateUserFile(string username, Dictionary<string, int> workoutData, string filePath)
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            var lines = File.ReadAllLines(filePath).ToList();
            int startIdx = lines.FindIndex(line => line.Contains($"[{username}]"));

            if (startIdx != -1)
            {
                int endIdx = lines.FindIndex(startIdx + 1, line => line.StartsWith("["));
                endIdx = endIdx == -1 ? lines.Count : endIdx;
                lines.RemoveRange(startIdx + 1, endIdx - startIdx - 1);

                foreach (var entry in workoutData)
                {
                    lines.Insert(++startIdx, $"{entry.Key}={entry.Value}");
                }
            }
            else
            {
                lines.Add($"[{username}]");
                lines.AddRange(workoutData.Select(entry => $"{entry.Key}={entry.Value}"));
            }

            File.WriteAllLines(filePath, lines);
        
        }
    
        
    }


}

       




