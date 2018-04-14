using Data_access_layer;
using Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Logic
    {
        //Data data = new Data();
        //static string path = @"Data Source =.\SQLEXPRESS;Initial Catalog = Users_n_Rewards; Integrated Security = True";
        static string path = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DataInDB data = new DataInDB(path);

        public List<User> GetUsers()
        {
            return data.GetUsers();
        }

        public List<Reward> GetRewards()
        {
            return data.GetRewards();
        }

        public void AddUser(User user)
        {
            data.AddUser(user);
        }

        public void AddReward (Reward reward)
        {
            data.AddReward(reward);
        }

        public void InitUsers()
        {
            data.InitUsers();
        }
        public void InitRewards()
        {
            data.InitRewards();
        }
        public void RemoveUser (User user)
        {
            data.RemoveUser(user);
        }
        public void RemoveReward(Reward reward)
        {
            data.RemoveReward(reward);
        }
        public void EditUser(User user)
        {
            data.EditUser(user);
        }
        public void EditReward(Reward reward)
        {
            data.EditReward(reward);
        }

        public User GetUserById(int id)
        {
            User user = data.GetUserById(id);
            return user;
        }

        public Reward GetRewardById(int id)
        {
            Reward reward = data.GetRewardById(id);
            return reward;
        }
    }
}
