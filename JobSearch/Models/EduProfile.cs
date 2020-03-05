using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class EduProfile
    {
        [Key]
        public int EId { get; set; }

       
        [ForeignKey("JsId")]
        public JobSeeker JobSeeker { get; set; }
        public int JsId { get; set; }
        

      
        


        [Display(Name = "College Name")]
        public string CollegeName { get; set; }

        

        
        public string Degree { get; set; }

        [Display(Name = "CGPA")]
        public Int16 CGPA { get; set; }

        [Display(Name = "Skill")]
        public string Skill { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Passing Year")]
        public Int32 Passing_Year { get; set; }



        [Display(Name = "Experiance")]
        public Int32 Experiance { get; set; }


        

        [Display(Name = "Entry_Date")]
        public DateTime Ent_date { get; set; }
        
        public EduProfile()
        {
            this.Ent_date = DateTime.Now;
        }

    }
}
