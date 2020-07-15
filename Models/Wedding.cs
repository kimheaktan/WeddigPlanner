using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        public int WeddingId {get;set;}

        [Required(ErrorMessage="is required.")]
        [Display(Name ="Wedder One")]
        public string WedderOne {get;set;}

        [Required(ErrorMessage="is required.")]
        [Display(Name ="Wedder Two")]
        public string WedderTwo {get;set;}

        [Required(ErrorMessage="is required.")]
        [Display(Name ="Wedding Date:")]
        [OnlyDateInFuture]
        public DateTime Date {get;set;}

        // [Required(ErrorMessage="is required.")]
        // [Display(Name ="Time:")]
        // public string Time { get;set; }


        [Required (ErrorMessage = "is required.")]
        [MinLength (2, ErrorMessage = "Street address must be at least 2 characters.")]
        [Display (Name = "Street Address:")]
        public string Street { get; set; }

        [Required (ErrorMessage = "is required.")]
        [MinLength (2, ErrorMessage = "City/Town must be at least 2 characters.")]
        [Display (Name = "City/Town:")]

        public string City { get; set; }

        [Required (ErrorMessage = "State is required.")]
        [Display (Name = "State:")]

        public string State { get; set; }

        [Required (ErrorMessage = "Zip code is required.")]
        [MinLength (5, ErrorMessage = "Zip code must be at least 5 characters.")]
        [Display (Name = "Zip code:")]

        public string Zip { get; set; }


        // [Required(ErrorMessage="is required.")]
        // [Display(Name ="Wedding Address:")]

        // public string Address {get;set;}

        public int CreatorId {get;set;}
        public User Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<RSVP> Attendees {get;set;}

        public string Wedders()
        {
            return WedderOne + " & " + WedderTwo;
        }

        public string Address()
        {
            return Street + " " + City + ", " + State + " " + Zip;
        }



    }


        public class OnlyDateInFutureAttribute: ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if((DateTime)value < DateTime.Now)
                    return new ValidationResult("Date must be in the Future");
                return ValidationResult.Success;
            }
        
        }


}


