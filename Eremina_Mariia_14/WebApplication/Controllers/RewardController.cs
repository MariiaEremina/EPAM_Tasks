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
        // GET: Reward
        public ActionResult Index()
        {
            Logic logic = new Logic();
            var rewards = logic.GetRewards();
            return View(rewards);
            //return View();
        }
    }
}