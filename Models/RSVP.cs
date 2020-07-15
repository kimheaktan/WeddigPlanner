namespace WeddingPlanner.Models
{
    public class RSVP
    {
        public int RSVPId {get;set;}

        public int UserId {get;set;} 

        public int WeddingId {get;set;}

        public bool IsRSVP {get;set;} = false;
        public Wedding Wedding {get;set;}
        public User User {get;set;}
    }
}
