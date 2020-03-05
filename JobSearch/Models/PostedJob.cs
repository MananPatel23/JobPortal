using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class PostedJob
    {
        [Key]
        public int JobId { get; set; }


        public int RecId { get; set; }
        [ForeignKey("RecId")]
        public Recruiter Recruiter { get; set; }

        [Display(Name = "Comapany Name")]
        public string CName { get; set; }



        [Display(Name = "Job Category")]
        public string Job_Cat { get; set; }

        [Display(Name = "Job Title")]
        public string Job_Tit { get; set; }


        [Display(Name = "Skill")]
       
        public string Skill { get; set; }



        [Display(Name = "Degree")]
        public string Degree{ get; set; }



        [Display(Name = "Salary")]
        public Int64 Salary { get; set; }


        [Display(Name = "Vacancy")]
        public int Vacancy { get; set; }


        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "Entry_Date")]
        
        public DateTime Ent_date { get; set; }

        public PostedJob()
        {
            this.Ent_date = DateTime.Now;
        }

        
    }
}

