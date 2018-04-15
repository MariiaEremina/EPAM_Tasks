using LogicLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        public Logic logic { get; set; }

        public UserController()
        {
            logic = new Logic();
        }

        public ActionResult Index()
        {
            logic = new Logic();
            var users = logic.GetUsers();
            return View(users);
        }

        public ActionResult Edit(int ID)
        {
            User user = logic.GetUserById(ID);
            List<Reward> allRewards = logic.GetRewards();
            UserViewModel UVM = new UserViewModel(user, allRewards);
            return View(UVM);
        }


        public ActionResult Delete(int ID)
        {
            User user = logic.GetUserById(ID);
            if (user != null)
            {
                logic.RemoveUser(user);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            User user = new User();
            List<Reward> allRewards = logic.GetRewards();
            UserViewModel UVM = new UserViewModel(user, allRewards);
            return View("Edit", UVM);
        }

        public ActionResult Save(UserViewModel UVM)
        {
            User editUser = UVM.ToUser();
            if (editUser.FirstName != default(string) && editUser.LastName != default(string) && editUser.Birthdate != default(DateTime))
            {
                if (editUser.ID == default(int))
                {
                        logic.AddUser(editUser);
                }
                else
                {
                    User user = logic.GetUserById(editUser.ID);
                    user.FirstName = editUser.FirstName;
                    user.LastName = editUser.LastName;
                    user.Birthdate = editUser.Birthdate;
                    if (editUser.reward != null)
                    {
                        user.reward = editUser.reward;
                        user.RefreshRewards(user.reward);
                    }
                    logic.EditUser(editUser);
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