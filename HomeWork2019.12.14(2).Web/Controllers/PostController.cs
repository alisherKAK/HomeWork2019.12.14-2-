using HomeWork2019._12._14_2_.AbstractModels;
using HomeWork2019._12._14_2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._14_2_.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IRepository<User> _userRepository;
        public PostController(IRepository<Post> postRepository, IRepository<User> userRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
        }

        public ActionResult Index(int id)
        {
            ViewBag.Id = id;
            return View(_postRepository.GetAll());
        }

        public ActionResult Create(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            _postRepository.Add(post);

            return RedirectToAction("Index", post.UserId);
        }
    }
}