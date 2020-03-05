using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class AppliedJob
    {

        [Key]
        public int AJId { get; set; }


        [ForeignKey("JobId")]
        public PostedJob postedJob { get; set; }
        public int JobId { get; set; }

        [ForeignKey("RecId")]
        public Recruiter Recruiter { get; set; }
        public int? RecId { get; set; }


        [ForeignKey("JSId")]
        public JobSeeker JobSeeker { get; set; }
        public int JSId { get; set; }


        [Display(Name = "Job Title")]
        public string Job_Tit { get; set; }


       

        [Display(Name = "Entry_Date")]
        public DateTime Ent_date { get; set; }

        public AppliedJob()
        {
            this.Ent_date = DateTime.Now;
        }

    }
}
