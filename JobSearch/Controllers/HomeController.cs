using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobSearch.Models;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace JobSearch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       

        
        
        public IActionResult Search(string Skill,string Job_Cat)
        {
            
            String connectionString = "Data Source = MANAN_WORKSTATI; Initial Catalog = JobSearch; User ID = root; Password = root";
            

                var model = new List<PostedJob>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                String sql = " SELECT * FROM postedJobs WHERE Skill=@Skill AND Job_Cat=@Job_Cat";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Skill",Skill);
                cmd.Parameters.AddWithValue("@Job_Cat", Job_Cat);





                conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var postedJob = new PostedJob();
                        postedJob.RecId = (int)rdr["RecID"];
                        postedJob.Job_Cat = (String)rdr["Job_Cat"];
                        postedJob.CName = (String)rdr["CName"];
                        postedJob.Skill = (String)rdr["Skill"];
                        postedJob.Degree = (String)rdr["Degree"];
                        postedJob.City = (String)rdr["City"];
                        postedJob.Salary = (Int64)rdr["Salary"];
                        postedJob.Vacancy = (int)rdr["Vacancy"];

                        model.Add(postedJob);
                    }




                }



                return View(model);
            
        }


      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
    }
}
