using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.ViewModels
{
    public class RewardViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }

        public static RewardViewModel GetViewModel(Reward reward, List<Reward> userRewards)
        {
            RewardViewModel newReward = new RewardViewModel();
            newReward.ID = reward.ID;
            newReward.Title = reward.Title;
            newReward.Description = reward.Description;
            newReward.Checked = false;

            if (!(userRewards is null))
            {
                foreach (Reward rew in userRewards)
                {
                    if (rew.ID == newReward.ID)
                    {
                        newReward.Checked = true;
                    }
                }
            }
            return newReward;
        }

        public static Reward ToReward(RewardViewModel rewardModel)
        {
            
            Reward reward = new Reward();
            reward.ID = rewardModel.ID;
            reward.Title = rewardModel.Title;
            reward.Description = rewardModel.Description;
            return reward;
        }
    }

}