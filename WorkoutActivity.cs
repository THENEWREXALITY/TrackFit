using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackFit
{
    public class WorkoutActivity
    {
        string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TrackFit");

        public Goal GoalType { get; set; }
        public static Dictionary<string, WorkoutTarget> WorkoutTargets { get; set; }

        private static Dictionary<Goal, Dictionary<string, WorkoutTarget>> fixedGoals;

        // Static constructor to initialize the fixedGoals dictionary
        static WorkoutActivity()
        {
            fixedGoals = new Dictionary<Goal, Dictionary<string, WorkoutTarget>>();

            // WeightLoss goals
            var weightLossTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(300, 30, 0)},
                {"Walking", new WorkoutTarget(160, 23, 0)},
                {"Weight Lifting", new WorkoutTarget(200, 20, 15)},
                {"Cycling", new WorkoutTarget(250, 45, 0)},
                {"Yoga", new WorkoutTarget(100, 60, 0)},
                {"Swimming", new WorkoutTarget(350, 50, 0)}
            };
            fixedGoals[Goal.WeightLoss] = weightLossTargets;

            // Strength goals
            var strengthTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(150, 15, 0)},
                {"Walking", new WorkoutTarget(200, 33, 0)},
                {"Weight Lifting", new WorkoutTarget(550, 90, 20)},
                {"Cycling", new WorkoutTarget(200, 30, 0)},
                {"Yoga", new WorkoutTarget(120, 45, 0)},
                {"Swimming", new WorkoutTarget(300, 40, 0)}
            };
            fixedGoals[Goal.Strength] = strengthTargets;

            // Endurance goals
            var enduranceTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(200, 20, 0)},
                {"Walking", new WorkoutTarget(190, 29, 0)},
                {"Weight Lifting", new WorkoutTarget(300, 30, 25)},
                {"Cycling", new WorkoutTarget(150, 15, 0)},
                {"Yoga", new WorkoutTarget(110, 30, 0)},
                {"Swimming", new WorkoutTarget(250, 20, 0)}
            };
            fixedGoals[Goal.Endurance] = enduranceTargets;

            // Cardio goals
            var cardioTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(150, 15, 0)},
                {"Walking", new WorkoutTarget(180, 28, 0)},
                {"Weight Lifting", new WorkoutTarget(100, 10, 15)},
                {"Cycling", new WorkoutTarget(350, 75, 0)},
                {"Yoga", new WorkoutTarget(120, 45, 0)},
                {"Swimming", new WorkoutTarget(320, 55, 0)}
            };
            fixedGoals[Goal.Cardio] = cardioTargets;

            // Flexibility goals
            var flexibilityTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(150, 15, 0)},
                {"Walking", new WorkoutTarget(184, 24, 0)},
                {"Weight Lifting", new WorkoutTarget(400, 60, 30)},
                {"Cycling", new WorkoutTarget(200, 55, 0)},
                {"Yoga", new WorkoutTarget(120, 30, 0)},
                {"Swimming", new WorkoutTarget(220, 20, 0)}
            };
            fixedGoals[Goal.Flexibility] = flexibilityTargets;

            // General goals
            var generalTargets = new Dictionary<string, WorkoutTarget>
            {
                {"Running", new WorkoutTarget(100, 1, 0)},
                {"Walking", new WorkoutTarget(189, 24, 0)},
                {"Weight Lifting", new WorkoutTarget(400, 40, 20)},
                {"Cycling", new WorkoutTarget(200, 20, 0)},
                {"Yoga", new WorkoutTarget(120, 20, 0)},
                {"Swimming", new WorkoutTarget(300, 30, 0)}
            };
            fixedGoals[Goal.General] = generalTargets;
        }






        public WorkoutActivity(Goal goalType)
        {
            GoalType = goalType;
            // Initialize the WorkoutTargets using the fixedGoals dictionary
            WorkoutTargets = new Dictionary<string, WorkoutTarget>(fixedGoals[goalType]);
        }
    }

    public class WorkoutTarget
    {
        public int TargetCalories { get; set; }
        public int TargetDuration { get; set; }
        public int TargetRepetitions { get; set; }
        public int Time { get; internal set; }
        public int Calories { get; internal set; }

        public WorkoutTarget(int calories, int duration, int repetitions)
        {
            TargetCalories = calories;
            TargetDuration = duration;
            TargetRepetitions = repetitions;
        }
    }
}


