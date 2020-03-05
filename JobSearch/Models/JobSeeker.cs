using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace JobSearch.Models
{
    public class JobSeeker
    {
        [Key]
        public int JSId { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        
        
        [Display(Name = "Email")]
        public string  Email{ get; set; }
       
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

      
       
        [Display(Name = "Pincode")]
        public Int32 Pincode { get; set; }

       
       
        [Display(Name = "Mobile")]
        public Int64 Mobile { get; set; }

       
        [Display(Name = "Date Of Birth")]
        public DateTime Dob { get; set; }

        
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "Entry_Date")]
        public DateTime Ent_date { get; set; }

        public JobSeeker()
        {
            this.Ent_date = DateTime.Now;
        }

        public virtual ICollection<EduProfile> eduProfiles { get; set; }
    }
}


