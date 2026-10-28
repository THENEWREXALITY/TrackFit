using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackFit
{
    public class Workouts
    {
        public string Name {  get; set; }
        public Goal UserGoal { get; set; }

        public int CaloriesBurned { get; set; }
        public int Duration {  get; set; }
        public int Repetitions {  get; set; }

        public Workouts( Goal userGoal, string name, int caloriesBurned, int duration, int repetitions)
        {
            
            UserGoal = userGoal;
            Name = name;
            CaloriesBurned = caloriesBurned;
            Duration = duration;
            Repetitions = repetitions;
        }

        

    }
}
