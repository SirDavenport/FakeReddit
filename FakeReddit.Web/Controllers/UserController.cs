using FakeReddit.Core.Models;
using FakeReddit.Services;
using FakeReddit.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FakeReddit.Web.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user);
                TempData["message"] = "Your account was created! Please Login";
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = _userService.GetUser((int)id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User
        public ActionResult Index()
        {
            if ((string)Session["token"] == "user_token")
            {
                return RedirectToAction("Index", "Post");
            }
            if ((string)Session["token"] == "admin_token")
            {
                return View(_userService.GetUsers());
            }
            return RedirectToAction("Login", "User");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginVM userVM)
        {
            Debug.WriteLine("Login called");
            if (userVM.Email == null || userVM.Password == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = _userService.GetUserByEmail(userVM.Email);
            var password = userVM.Password;

            if (user != null)
            {
                if (user.Password == password && user.Role == "ADMIN")
                {
                    Session["token"] = "admin_token";
                    Session["user_id"] = user.Id;
                    Debug.WriteLine(Session["token"]);
                    return RedirectToAction("Index", "User");
                }
                else if (user.Password == password && user.Role == "USER")
                {
                    Session["token"] = "user_token";
                    Session["user_id"] = user.Id;
                    return RedirectToAction("Index", "Post");
                }
                else
                {
                    TempData["message"] = "Invalid credentials";
                    return View();
                }
            }
            TempData["message"] = "Invalid credentials";
            return View();
        }

        public ActionResult Logout()
        {
            Session["token"] = null;
            return RedirectToAction("Login", "User");
        }
    }
}
