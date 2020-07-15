using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class AllWeddings
    {
        public List<Wedding> ExistingWeddings {get;set;}
        public RSVP RSVP {get;set;}
        public User LoggedInUser {get;set;}
        public List<RSVP> Attendees {get;set;}
    }
}