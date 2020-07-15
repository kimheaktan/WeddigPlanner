using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]// denotes PK, not needed if named ModelNameId 
        public int UserId {get;set;} 

        [Required(ErrorMessage = "is required")] 
        [Display(Name = "First Name")] 
        [MinLength(2, ErrorMessage = "must be at least 2 characters")] 

        public string FirstName {get;set;} 

        [Required(ErrorMessage = "is required")] 
        [Display(Name = "Last Name")] 
        [MinLength(2, ErrorMessage = "must be at least 2 characters")] 

        public string LastName {get;set;} 

        [Required(ErrorMessage = "is required")] 
        [Display(Name = "Email Address")] 
        [EmailAddress] 
        public string Email {get;set;}   

        [Required(ErrorMessage = "is required")] 
        [Display(Name = "Password")] 
        [MinLength(8,ErrorMessage ="has to be at least 8 characters.")]
        [DataType(DataType.Password)] 
        public string Password{get;set;} 

        [NotMapped] 
        [Compare("Password", ErrorMessage = "doesn't match password")] 
        [Display(Name = "Confirm Password")] 
        [DataType(DataType.Password)] 
        public string ConfirmPassword {get;set;}
        public DateTime CreatedAt {get;set;}=DateTime.Now; 
        public DateTime UpdatedAt {get;set;}=DateTime.Now; 

        public List<RSVP> RSVPs {get;set;}

        public List<Wedding> Weddings {get;set;}
        public string FullName() 
        { 
            return LastName + ", " + FirstName; 
        } 

    } 
}