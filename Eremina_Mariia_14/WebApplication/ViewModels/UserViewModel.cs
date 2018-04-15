using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.ViewModels
{
    public class UserViewModel
    {

        public UserViewModel()
        {

        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public List<RewardViewModel> AllRewards { get; set; }


        public UserViewModel(User one, List<Reward> rewards)
        {
            ID = one.ID;
            FirstName = one.FirstName;
            LastName = one.LastName;
            Birthdate = one.Birthdate;
            AllRewards = new List<RewardViewModel>();

            foreach (Reward reward in rewards)
            {
                RewardViewModel rewardModel = RewardViewModel.GetViewModel(reward, one.reward);
                AllRewards.Add(rewardModel);
            }
        }

        public User ToUser()
        {
            User user = new User();
            user.ID = ID;
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Birthdate = Birthdate;
            user.reward = ToRewards();
            return user;
        }

        public List<Reward> ToRewards()
        {
            List<Reward> resultRewards = new List<Reward>();
            foreach (RewardViewModel rewardModel in AllRewards)
            {
                if (rewardModel.Checked)
                {
                    resultRewards.Add(RewardViewModel.ToReward(rewardModel));
                }
            }
            return resultRewards;
        }
    }
}