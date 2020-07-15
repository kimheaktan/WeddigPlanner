using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = "is required")] 
        [EmailAddress] 
        [Display(Name = "Email Address")]
        public string LoginEmail {get;set;}

        [Required(ErrorMessage = "is required")] 
        [DataType(DataType.Password)] 
        [Display(Name = "Password")] 
        public string LoginPassword {get;set;}
    }
}