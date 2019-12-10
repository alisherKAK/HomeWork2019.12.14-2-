using HomeWork2019._12._14_2_.AbstractModels;
using HomeWork2019._12._14_2_.Models;
using HomeWork2019._12._14_2_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._14_2_.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository<User> _repository;
        public UserController(IRepository<User> repository)
        {
            _repository = repository;
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            user.Password = Hashing.HashPassword(user.Password);
            
            _repository.Add(user);

            return RedirectToAction("SignIn");
        }

        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(User user)
        {
            var foundedUser = _repository.GetAll().Where(u => u.Login == user.Login).FirstOrDefault();

            if(foundedUser != null && Hashing.ValidatePassword(user.Password, foundedUser.Password))
                return Redirect("/Post/Index/" + foundedUser.Id);

            return RedirectToAction("SignIn");
        }
    }
}