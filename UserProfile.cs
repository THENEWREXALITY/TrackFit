using System;

namespace TrackFit
{
    public class UserProfile
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Goal UserGoal { get; set; }

        public UserProfile(string username, string password,string fullname, int age, Goal goal)
        {
            Username = username;
            Password = password;
            FullName = fullname;
            Age = age;
            UserGoal = goal;   
        }

        public override string ToString()
        {
            return $"User: {Username}, Password: {Password}, FullName: {FullName}, Age: {Age}, Goal: {UserGoal}";
        }
    }


}
