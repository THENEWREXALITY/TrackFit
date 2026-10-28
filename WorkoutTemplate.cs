using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackFit
{
    public class WorkoutTemplate
    {
        public string ExerciseName { get; set; }
        public int DefaultDuration { get; set; }
        public int DefaultCaloriesBurned { get; set; }

        public WorkoutTemplate(string exerciseName, int defaultDuration, int defaultCaloriesBurned) 
        {
            ExerciseName = exerciseName;
            DefaultDuration = defaultDuration;
            DefaultCaloriesBurned = defaultCaloriesBurned;
        }
    }
}
