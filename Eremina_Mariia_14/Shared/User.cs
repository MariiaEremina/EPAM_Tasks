using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class User
    {

        
        //{
        //    get
        //    {
        //        return id;
        //    }

        //    private set
        //    {
        //        ID = value;
        //    }
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; }
        public string Rewards { get; private set; }
        public List<Reward> reward { get; set; }
        private static int id = 0;
        public int ID { get; set; }


        public User()
        {
        }

        public User(string firstName, string lastName, DateTime birthdate, List<Reward> rew)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Age = GetAge(birthdate);
            reward = rew;
            Rewards = String(reward);
            ID = id;
            id++;
        }

        public User(string firstName, string lastName, DateTime birthdate, List<Reward> rew, int Id)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Age = GetAge(birthdate);
            reward = rew;
            Rewards = String(reward);
            ID = Id;
        }

        public User(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Age = GetAge(birthdate);
            reward = new List<Reward>();
            Rewards = String(reward);
            ID = id;
            id++;
        }

        public User(string firstName, string lastName, DateTime birthdate, int Id)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Age = GetAge(birthdate);
            reward = new List<Reward>();
            Rewards = String(reward);
            ID = Id;
        }

        private int GetAge(DateTime birthdate)
        {
            int age;
            DateTime today = DateTime.Now;
            if ((birthdate.Month > today.Month) || (birthdate.Month == today.Month && birthdate.Day > today.Day))
            {
                age = today.Year - (birthdate.Year + 1);
            }
            else
            {
                age = today.Year - (birthdate.Year);
            }
            return age;
        }

        private string String(List<Reward> rew)
        {
            string s = "";
            if (rew != null)
                
            {
                if (rew.Count != 0)
                {
                    s = rew[0].Title;
                    for (int i = 1; i < rew.Count; i++)
                    {

                        s += ", " + rew[i].Title;
                    }
                }
            }
            return s;
        }

        public void RefreshRewards (List<Reward> rewards)
        {
            Rewards = String(rewards);
        }
    }
}
