using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CODStats.Models
{
    public class User
    {
        [Key]
        public int UserId{get; set;}

        [Required(ErrorMessage="First name is required.")]
        [MinLength(2,ErrorMessage="First name must be at least 2 characters.")]
        [Display(Name="First Name: ")]
        public string FirstName {get; set;}

        [Required(ErrorMessage="Last name is required.")]
        [MinLength(2,ErrorMessage="Last name must be at least 2 characters.")]
        [Display(Name="Last Name: ")]
        public string LastName {get; set;}

        [Required(ErrorMessage="Gamer Tag must be provided.")]
        [MinLength(2,ErrorMessage="Gamer Tag must be at least 2 characters.")]
        [Display(Name="Gamer Tag: ")]

        public string GamerTag {get; set;}

        [Required(ErrorMessage="Birthday must be provided.")]
        [PastDate]
        [Display(Name="Birthday: ")]
        public DateTime Date {get; set;}

        [Required(ErrorMessage="Email is required.")]
        [EmailAddress]
        [Display(Name="Email: ")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password is required.")]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name="Password: ")]
        public string Password {get; set;}

        [Required(ErrorMessage="Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="Those don't match.")]
        [Display(Name="Confirm Password: ")]
        [NotMapped]
        public string ConfirmPassword {get; set;}


        public List<Team> JoinedTeam {get; set;}





        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        /////////////////////

        public class PastDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime check;
                if(value is DateTime)
                {
                    check = (DateTime)value;
    
                    if(check > DateTime.Now)
                    {
                        return new ValidationResult("Birthday must be in the past.");
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                else
                {
                    return new ValidationResult("Enter a real date.");
                }
            }
        }
    }
}