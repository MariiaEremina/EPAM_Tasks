﻿using LogicLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            Logic logic = new Logic();
            var users = logic.GetUsers();
            return View(users);
        }
    }
}