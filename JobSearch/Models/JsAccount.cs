using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class JsAccount
    {

        public string JsName { get; set; }

        public string City { get; set; }

       public Int32 Experiance { get; set; }

       public string CollegeName { get; set; }

       public string Degree { get; set; }

        public int CGPA { get; set; }

        public string Category { get; set; }

        public string Skill { get; set; }

        public Int32 PassingYear { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public Int64 Mobile { get; set; }

        public string Job_Title { get; set; }

        public System.DateTime AppOn { get; set; }

        public IList<JsAccount> js { get; set; }





    }
}
