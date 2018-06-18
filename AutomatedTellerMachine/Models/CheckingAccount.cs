using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(10, MinimumLength=6)]
        [RegularExpression(@"\d{6,10}", ErrorMessage="Account # must be between 6 to 10 digits")]
        [Display(Name="Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name="First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name="Last name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format(" {0} {1}", this.FirstName, this.LastName);
            }
        }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        // Added the property that will be reference to the User that will hold the account, this will automatically implemented with a foreign key that refernces the User table when data base is generated making it a virtual property allow to override by the framework with a mechinsism that sypports lazy loading of this related object
        public virtual ApplicationUser User { get; set; }


        // implemented Id property of the ApplicationUser
        public string ApplicationUserId { get; set; }
    }
}