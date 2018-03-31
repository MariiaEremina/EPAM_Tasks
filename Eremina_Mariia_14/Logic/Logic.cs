using Data_access_layer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Logic
    {
        Data data = new Data();

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
    }
}
