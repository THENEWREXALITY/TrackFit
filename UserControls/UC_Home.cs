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
using System.Runtime.CompilerServices;

namespace TrackFit.UserControls
{
    public partial class UC_Home : UserControl
    {
        private readonly string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");
        private string loggedInUsername;
        private UC_Activities ucActivities;
        private Timer timer;
        private int targetProgress = 50;
        private Dictionary<string, int> targetProgressValues;   

        public UC_Home()
        {
            InitializeComponent();
            InitializeProgressBars();
            SetTargetProgressValues();

            ucActivities = new UC_Activities("loggedInUsername");
        }

        public UC_Home(UC_Activities inputControl)
        {
            InitializeComponent();
            ucActivities = inputControl;
            SetTargetProgressValues();
        }

        

        public UC_Home(string username) : this()
        {
            loggedInUsername = username;
        }

        

        private void InitializeProgressBars()
        {
            ExProgBar1.Value = 0;
            ExProgBar1.Minimum = 0;
            ExProgBar1.Maximum = 100;

            ExProgBar2.Value = 0;
            ExProgBar2.Minimum = 0;
            ExProgBar2.Maximum = 100;

            ExProgBar3.Value = 0;
            ExProgBar3.Minimum = 0;
            ExProgBar3.Maximum = 100;

            ExProgBar4.Value = 0;
            ExProgBar4.Minimum = 0;
            ExProgBar4.Maximum = 100;

            ExProgBar5.Value = 0;
            ExProgBar5.Minimum = 0;
            ExProgBar5.Maximum = 100;

            ExProgBar6.Value = 0;
            ExProgBar6.Minimum = 0;
            ExProgBar6.Maximum = 100;

            CalProgBar1.Value = 0;
            CalProgBar1.Minimum = 0;
            CalProgBar1.Maximum = 1000;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;

        }

        private void SetTargetProgressValues()
        {
            targetProgressValues = new Dictionary<string, int>
            {
                { "Walking", 1500 },
                { "Swimming", 1600 },
                { "Running", 2750 },
                { "Cycling", 2400 },
                { "Yoga", 1300 },
                { "Weights", 3550 }
            };
        }

        private void UpdateProgressBar(ProgressBar progressBar, string activity)
        {
            int target = targetProgressValues[activity];

            
            if (progressBar.Value < target)
            {
                progressBar.Value += 1; // Adjust this increment value for speed
            }
        }

        private bool AllProgressBarsReachedTarget()
        {
            return ExProgBar1.Value >= targetProgressValues["Walking"] &&
                   ExProgBar2.Value >= targetProgressValues["Swimming"] &&
                   ExProgBar3.Value >= targetProgressValues["Running"] &&
                   ExProgBar4.Value >= targetProgressValues["Cycling"] &&
                   ExProgBar5.Value >= targetProgressValues["Yoga"] &&
                   ExProgBar6.Value >= targetProgressValues["Weights"];
        }

        private int UpdateActivityProgress()
        {
            throw new NotImplementedException();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            UpdateProgressBarsFromActivities(); 
            timer.Start();
        }

        private void UpdateProgressBarsFromActivities()
        {
            // Access values from UC_Activities
            int walkingCalories = ucActivities.Exercise1Value;
            int swimmingCalories = ucActivities.Exercise2Value;
            int runningCalories = ucActivities.Exercise3Value;
            int cyclingCalories = ucActivities.Exercise4Value;
            int yogaCalories = ucActivities.Exercise5Value;
            int weightsCalories = ucActivities.Exercise6Value;

            // Set target values to incrementally reach in progress bars
            ExProgBar1.Maximum = 100;
            ExProgBar1.Value = ucActivities.Exercise1Value;
            ExProgBar2.Maximum = 100;
            ExProgBar2.Value = ucActivities.Exercise2Value;
            ExProgBar3.Maximum = 100;
            ExProgBar3.Value = ucActivities.Exercise3Value;
            ExProgBar4.Maximum = 100;
            ExProgBar4.Value = ucActivities.Exercise4Value;
            ExProgBar5.Maximum = 100;
            ExProgBar5.Value = ucActivities.Exercise5Value;
            ExProgBar6.Maximum = 100;
            ExProgBar6.Value = ucActivities.Exercise6Value;
        }

        private void UpdateActivityProgress(string activity, WorkoutTarget target, int actualCalories, int actualDuration, int actualRepetitions)
        {
            int CalculateProgress(int actual, int targetValue) =>
                targetValue > 0 ? (int)((double)actual / targetValue * 100) : 0;

            int caloriesProgress = CalculateProgress(actualCalories, target.TargetCalories);
            int durationProgress = CalculateProgress(actualDuration, target.TargetDuration);
            int repetitionsProgress = CalculateProgress(actualRepetitions, target.TargetRepetitions);

            int averageProgress = (caloriesProgress + durationProgress + repetitionsProgress) / 3;

            switch (activity)
            {
                case "Walking":
                    ExProgBar1.Value = Math.Min(averageProgress, 100);
                    break;
                case "Swimming":
                    ExProgBar2.Value = Math.Min(averageProgress, 100);
                    break;
                case "Running":
                    ExProgBar3.Value = Math.Min(averageProgress, 100);
                    break;
                case "Cycling":
                    ExProgBar4.Value = Math.Min(averageProgress, 100);
                    break;
                case "Yoga":
                    ExProgBar5.Value = Math.Min(averageProgress, 100);
                    break;
                case "Weights":
                    ExProgBar6.Value = Math.Min(averageProgress, 100);
                    break;
            }

            
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ExProgBar1.Value < ExProgBar1.Maximum) ExProgBar1.Value++;
            if (ExProgBar2.Value < ExProgBar2.Maximum) ExProgBar2.Value++;
            if (ExProgBar3.Value < ExProgBar3.Maximum) ExProgBar3.Value++;
            if (ExProgBar4.Value < ExProgBar4.Maximum) ExProgBar4.Value++;
            if (ExProgBar5.Value < ExProgBar5.Maximum) ExProgBar5.Value++;
            if (ExProgBar6.Value < ExProgBar6.Maximum) ExProgBar6.Value++;

            // Stop the timer if all progress bars have reached their max
            if (ExProgBar1.Value >= ExProgBar1.Maximum &&
                ExProgBar2.Value >= ExProgBar2.Maximum &&
                ExProgBar3.Value >= ExProgBar3.Maximum &&
                ExProgBar4.Value >= ExProgBar4.Maximum &&
                ExProgBar5.Value >= ExProgBar5.Maximum &&
                ExProgBar6.Value >= ExProgBar6.Maximum)
            {
                timer.Stop();
            }
        }

        private void UpdateOverallProgress(Dictionary<string, (WorkoutTarget target, int calories, int duration, int reps)> workoutData)
        {
            int totalProgress = 0;
            int activityCount = workoutData.Count;

            foreach (var activity in workoutData)
            {
                var (target, actualCalories, actualDuration, actualReps) = activity.Value;

                int caloriesProgress = (int)((double)actualCalories / target.TargetCalories * 100);
                int durationProgress = (int)((double)actualDuration / target.TargetDuration * 100);
                int repetitionsProgress = (int)((double)actualReps / target.TargetRepetitions * 100);

                int activityProgress = (caloriesProgress + durationProgress + repetitionsProgress) / 3;
                totalProgress += Math.Min(activityProgress, 100); // Ensure each progress is capped at 100%
            }

            int overallProgress = totalProgress / activityCount;
            CalProgBar1.Value = Math.Min(overallProgress, 100);
        }



    }


}
