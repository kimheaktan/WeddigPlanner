using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private WPContext _db; 

        public WeddingController(WPContext context) 
        { 
            _db = context; 
        } 

        private int? _uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private bool _isLoggedIn
        {
            get
            {
                int? uid = _uid;

                if (uid != null)
                {
                    User loggedInUser =
                        _db.Users.FirstOrDefault(u => u.UserId == uid);

                    HttpContext.Session
                        .SetString("FullName", loggedInUser.FullName());
                }
                return uid != null;
            }
        }
        public IActionResult NewWeddingForm()
        {
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult CreateWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                int? _uid = HttpContext.Session.GetInt32("UserId");

                User currUser = _db.Users.FirstOrDefault(u => u.UserId == _uid);

                int creatorId = currUser.UserId;
                Wedding newW = new Wedding{
                    WedderOne = newWedding.WedderOne,
                    WedderTwo = newWedding.WedderTwo,
                    Date = newWedding.Date,
                    Street = newWedding.Street,
                    City = newWedding.City,
                    State = newWedding.State,
                    Zip = newWedding.Zip,
                    CreatorId = creatorId,
                    // this way because we don't want to pass CreatorId from "Hidden input" in the View  in case User make a mistake filling the form and needed to View (error messages) and there won't be any data to load on View
                };

                _db.Weddings.Add(newW);
                _db.SaveChanges();

                int WedId = newW.WeddingId;
                RSVP creatorRSVP = new RSVP{UserId = creatorId, WeddingId = WedId, IsRSVP = true};

                _db.RSVPs.Add(creatorRSVP);
                _db.SaveChanges();

                return RedirectToAction("Weddings");
            }
                // return RedirectToAction("NewWeddingForm");
            return View("NewWeddingForm");
        }

        [HttpGet("Dashboard")]
        public IActionResult Weddings()
        {
            // int _uid = (int)HttpContext.Session.GetInt32("UserId");
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            
            User loggedInUser = _db.Users.Include(u => u.RSVPs).ThenInclude(r => r.Wedding).FirstOrDefault(u => u.UserId == _uid);

            List<Wedding> allWeddings = _db.Weddings.Include(u => u.Attendees).ThenInclude(r => r.User).OrderBy(w => w.Date).ToList();

            AllWeddings info = new AllWeddings{ExistingWeddings = allWeddings, LoggedInUser = loggedInUser};

            // ~~~~~~~~~~Remove past Weddings~~~~~~~~~~~~
            DateTime  CurrentTime = DateTime.Now;
            foreach (var wedding in allWeddings)
            {
                if(wedding.Date < CurrentTime)
                {
                    _db.Weddings.Remove(wedding);
                    _db.SaveChanges();
                }
            }

            return View(info);
        }

        [HttpGet("wedding/{WedId}")]
        public IActionResult ViewWedding(int WedId)
        {
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            Wedding toBeViewed = _db.Weddings.Include(w => w.Attendees).ThenInclude(a => a.User).FirstOrDefault(w => w.WeddingId == WedId);

            return View(toBeViewed);
        }

        [HttpGet("wed/{WedId}")]
        public IActionResult Delete(int WedId)
        {
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            Wedding toBeDeleted = _db.Weddings.FirstOrDefault(w => w.WeddingId == WedId);
            _db.Weddings.Remove(toBeDeleted);
            _db.SaveChanges();

            return RedirectToAction("Weddings");
        }

        [HttpGet("rsvp/{WedId}")]
        public IActionResult RSVP(int WedId)
        {
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            int? _uid = HttpContext.Session.GetInt32("UserId");
            User currUser = _db.Users.FirstOrDefault(u => u.UserId == _uid);

            Wedding currWed = GetAWedding(WedId);

            RSVP rsvp = new RSVP{
                    UserId = currUser.UserId, 
                    WeddingId = currWed.WeddingId
                };
            _db.RSVPs.Add(rsvp);
            _db.SaveChanges();

            
            return RedirectToAction("Weddings");
        }

        [HttpGet("unrsvp/{WedId}")]

        public IActionResult UnRSVP( int WedId)
        {
            if(!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
                Wedding currWed = GetAWedding(WedId);

                RSVP toBeDeleted = _db.RSVPs.FirstOrDefault(r => r.WeddingId == currWed.WeddingId && r.UserId == _uid);
                _db.RSVPs.Remove(toBeDeleted);
                _db.SaveChanges();

            return RedirectToAction("Weddings");
        }

        public Wedding GetAWedding(int WedId)
        {
            Wedding retrievedWedding = _db.Weddings.FirstOrDefault(w => w.WeddingId == WedId);
            return retrievedWedding;
        }
    }
}