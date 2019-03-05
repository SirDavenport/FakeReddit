using FakeReddit.Core.Models;
using FakeReddit.Services;
using FakeReddit.Web.ViewModels.PostVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FakeReddit.Web.Controllers
{
    public class PostController : Controller
    {
        private PostService _postService;
        private UserService _userService;

        public PostController()
        {
            _postService = new PostService();
            _userService = new UserService();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = _postService.GetPost((int)id);
            if (post == null)
            {
                return HttpNotFound();
            }
            var postVM = new PostDetailVM();
            postVM.Post = post;
            postVM.Email = _userService.GetUser((int)post.UserId).Email;

            return View(postVM);
        }

        // GET: Post
        public ActionResult Index()
        {
            if ((string)Session["token"] == "admin_token" || (string)Session["token"] == "user_token")
            {
                return View(_postService.GetPosts());
            }
            return RedirectToAction("Login", "User");
        }
    }
}
