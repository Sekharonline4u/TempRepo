using System;
using System.Collections.Generic;

namespace Training.Model
{
    public class Session
    {
        public string Trainer { get; set; }
        public string Topic { get; set; }
        public int DifficultyLevel { get; set; }
    }

    public class SessionRepo
    {
        public List<Session> GetSessions()
        {
            return new List<Session>()
            {
                new Session()
                {
                    Trainer = "Sekhar",
                    Topic = "Xamarin.Forms",
                    DifficultyLevel = 100
                },

                new Session()
                {
                    Trainer = "Srinivasan",
                    Topic = "Python 3 Step By Step",
                    DifficultyLevel = 100
                },
                new Session()
                {
                    Trainer = "Sekhar",
                    Topic = "Object Oriented Programming with Python",
                    DifficultyLevel = 200
                },
                new Session()
                {
                    Trainer = "Sekhar",
                    Topic = "AWS SysOps Certification",
                    DifficultyLevel = 300
                }
            };
        }
    }
}
