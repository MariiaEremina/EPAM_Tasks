using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Data_access_layer
{
    public class Data
    {
        private List<User> users;
        private List<Reward> rewards;


        public List<User> GetUsers()
        {
            return users;
        }

        public List<Reward> GetRewards()
        {
            return rewards;
        }

        public void AddUser(User user1)
        {
            User user2 = new User(user1.FirstName, user1.LastName, user1.Birthdate, user1.reward);
            users.Add(user2);

        }

        public void AddReward(Reward reward1)
        {
            Reward reward2 = new Reward(reward1.Title, reward1.Description);
            rewards.Add(reward2);
        }


        public void InitUsers()
        {
            users = new List<User>();
            DateTime d1 = new DateTime(1995, 05, 02);
            User user1 = new User("Username", "First", d1);
            users.Add(user1);

            DateTime d2 = new DateTime(1992, 05, 02);
            User user2 = new User("Username", "Second", d2);
            users.Add(user2);

            DateTime d3 = new DateTime(1995, 06, 08);
            List<Reward> rewards3 = new List<Reward>();
            rewards3.Add(rewards[1]);
            User user3 = new User("Anothername", "Third", d3, rewards3);
            users.Add(user3);

            DateTime d4 = new DateTime(1993, 11, 11);
            List<Reward> rewards4 = new List<Reward>();
            rewards4.Add(rewards[0]);
            rewards4.Add(rewards[1]);
            User user4 = new User("Another", "First", d4, rewards4);
            users.Add(user4);

            DateTime d6 = new DateTime(1995, 05, 02);
            User user6 = new User("Strangename", "Fourth", d6);
            users.Add(user6);
        }

        public void InitRewards()
        {
            rewards = new List<Reward>();

            Reward r1 = new Reward("Firstreward", "Awwwww, so reward!");
            rewards.Add(r1);

            Reward r2 = new Reward("AnotherAnother", "Double reward!");
            rewards.Add(r2);

            Reward r3 = new Reward("Another");
            rewards.Add(r3);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public void RemoveReward(Reward removeReward)
        {

            foreach (User user in users)
            {
                if (user.reward != null)
                {
                    if (user.reward.Contains(removeReward))
                    {
                        user.reward.Remove(removeReward);
                        user.RefreshRewards(user.reward);
                    }
                }
            }

            rewards.Remove(removeReward);

        }

        public void EditUser(User user)
        {

        }
        public void EditReward(Reward reward)
        {

        }

        //public User GetUserById(int id)
        //{

        //    return user;
        //}

        //public Reward GetRewardById(int id)
        //{

        //    return reward;
        //}
    }
}
