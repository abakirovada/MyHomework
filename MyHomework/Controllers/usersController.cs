﻿//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using MyHomework.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace MyHomework.Controllers
//{
//    [Authorize]
//    public class usersController : Controller
//    {
//        // GET: users
//        public ActionResult Index()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                var user = User.Identity;
//                ViewBag.Name = user.Name;

//                ViewBag.displayMenu = "No";

//                if (isAdminUser())
//                {
//                    ViewBag.displayMenu = "Yes";
//                }
//                return View();
//            }
//            else
//            {
//                ViewBag.Name = "Not Logged IN";
//            }
//            return View();
//        }
//        public Boolean isAdminUser()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                var user = User.Identity;
//                ApplicationDbContext context = new ApplicationDbContext();
//                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
//                var s = UserManager.GetRoles(user.GetUserId());
//                if (s[0].ToString() == "Admin")
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            return false;
//        }
//    }

//}