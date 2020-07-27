using System;
using System.ComponentModel.DataAnnotations;

namespace CODStats.Models
{
    public class Team
    {
        [Key]
        public int TeamId {get; set;}

        [Required(ErrorMessage="Team Name is required.")]
        [Display(Name="Team Name: ")]
        public string Name {get; set;}
        public string MemberOne {get; set;}
        public string MemberTwo {get; set;}
        public string MemberThree {get; set;}
        public string MemberFour {get; set;}
        public string MemberFive {get; set;}

        public string Location {get; set;}


        //////////////////////////// One to Many
        public int UserId {get; set;}
        public User Captain {get; set;}



        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}