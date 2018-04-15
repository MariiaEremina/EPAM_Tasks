using LogicLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class RewardController : Controller
    {
        public Logic logic { get; set; }

        public RewardController ()
        {
            logic = new Logic();
        }
        // GET: Reward
        public ActionResult Index()
        {
            
            var rewards = logic.GetRewards();
            return View(rewards);
            //return View();
        }

        public ActionResult Edit(int ID)
        {
            Reward reward = logic.GetRewardById(ID);
            return View(reward);
        }

        public ActionResult Delete(int ID)
        {
            Reward reward = logic.GetRewardById(ID);
            if (reward != null)
            {
                logic.RemoveReward(reward);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            Reward reward = new Reward();
            return View("Edit", reward);
        }

        public ActionResult Save (Reward editReward)
        {
            if (editReward.Title != default(string))
            {
                if (editReward.ID == default(int))
                {
                        logic.AddReward(editReward);
                }
                else
                {
                    Reward reward = logic.GetRewardById(editReward.ID);
                    reward.Title = editReward.Title;
                    reward.Description = editReward.Description;
                    logic.EditReward(reward);
                }

                return RedirectToAction("Index");
            }
            else return RedirectToAction("Message");
        }

        public ActionResult Message()
        {
            return View();
        }

    }
}