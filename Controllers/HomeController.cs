using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private WPContext _db; 

        public HomeController(WPContext context) 
        { 
            _db = context; 
        }
        public IActionResult Index()
        {
            int? _uid = HttpContext.Session.GetInt32("UserId");
            if(_uid != null)
            {
                return RedirectToAction("Weddings", "Wedding");
            }
            return View();
        }
        
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                bool isEmailTaken = _db.Users.Any(u => u.Email == newUser.Email);//Any() will return True if there's a match 
                if(isEmailTaken){// means if it's True
                    ModelState.AddModelError("Email", "Email is Taken");
                    return View("Index");
                }
                else{
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                        newUser.Password = hasher.HashPassword(newUser,newUser.Password);

                        _db.Users.Add(newUser);
                        _db.SaveChanges();

                        HttpContext.Session.SetInt32("UserId", newUser.UserId);

                        
                }
            }
            else{
                return View("Index");
            }
            return RedirectToAction("Weddings", "Wedding");
        }

        [HttpGet("login")]
        public IActionResult _Login()
        {
            int? _uid = HttpContext.Session.GetInt32("UserId");
            if(_uid != null)
            {
            return RedirectToAction("Weddings", "Wedding");
            }
            return View();
        }

        [HttpPost("login/user")]
        public IActionResult Login(LoginUser loginUser)
        {
            if(ModelState.IsValid)
            {
                User dbUser = _db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
                if(dbUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Credentials");
                }
                else
                {
                //instatiate a User and assigning loginUser's props to User props so that loginUser and dbUser will match during VerifyHashedPassword method
                    User loggingInUser = new User{
                        Email = loginUser.LoginEmail, Password = loginUser.LoginPassword
                    };
                    PasswordHasher<User> hasher = new PasswordHasher<User>();

                    PasswordVerificationResult result = hasher.VerifyHashedPassword(loggingInUser, dbUser.Password, loggingInUser.Password);

                    if(result == 0)//not matched password/failed
                    {
                        ModelState.AddModelError("LoginEmail", "Invalid Credentials");
                    }
                    else{
                        HttpContext.Session.SetInt32("UserId", dbUser.UserId);
                    }
                }
            }
            if(!ModelState.IsValid) // or Modelstate.IsValid == flase
            {
                return View("_Login");
            }

            return RedirectToAction("Weddings", "Wedding");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
