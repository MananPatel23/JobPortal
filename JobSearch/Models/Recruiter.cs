using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class Recruiter
    {

        [Key]
        public int RecId { get; set; }

        [Display(Name = "Company_Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string CName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = "Pincode")]
        public Int32 Pincode { get; set; }



        [Display(Name = "Contact Mobile")]
        public Int64 Mobile { get; set; }


       


        [Display(Name = "Entry_Date")]
        public DateTime Ent_date { get; set; }

        public Recruiter()
        {
            this.Ent_date = DateTime.Now;
        }
        

       
    }
}

