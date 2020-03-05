using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class AppliedJobDetails
    {
        public string ComapanyName { get; set; }

        public string Job_Title { get; set; }

        public System.DateTime Ent_date { get; set; }

        public IList<AppliedJobDetails> details { get; set; }

    }
}
