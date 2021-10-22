using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankAutomationSystem2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public long Contact { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        //[ForeignKey("CourseTrainer")]
        //public long AccountNo { get; set; }
        ////public virtual BankAccount AccountNo { get; set; }
        //public ICollection<BankAccount> BankAccounts { get; set;}
    }

    //    public class BankAccount
    //{
    //    [Key]
    //    public long AccountNo { get; set; }
    //    public int Balance { get; set; }
    //    public virtual User Users { get; set; }

    //}

         
}