using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobSearch.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;

namespace JobSearch.Controllers
{


    public class JobSeekersController : Controller
    {
        private readonly OurDbContext _context;



        const string Email = "Name";
        const string JsId = "Name";

        public JobSeekersController(OurDbContext context)
        {
            _context = context;
        }

        public IActionResult Home()
        {
            ViewBag.email = HttpContext.Session.GetString(Email);

            return View();
        }
        [HttpGet]
        public IActionResult JobSeekerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JobSeekerLogin(Models.JobSeeker jobSeeker)
        {
            var account = _context.JobSeekers.Where(u => u.Email == jobSeeker.Email && u.Password == jobSeeker.Password).FirstOrDefault();
            
            if (account != null)
            {

                
                HttpContext.Session.SetString(Email, jobSeeker.Email);
                

                return RedirectToAction(nameof(Home));

            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong.");
            }
            return View();
        }

        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("JobSeekerLogin");
        }

        [HttpGet]
        public IActionResult JobSeekerEduPro()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Edu()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Edu(EduProfile profile)
        {
            using (_context)
            {
                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.JobSeekers
                            where p.Email == email
                            select p;
                var id = query.Single();

                var jsid = id.JSId;
                

                

                //JobSeeker seeker = _context.JobSeekers.FirstOrDefault(s => s.JSId == jsid);

                profile.JsId = jsid;

                



                if (ModelState.IsValid)
                {

                    _context.Add(profile);


                    await _context.SaveChangesAsync();

                    return View(nameof(Home));


                }
                return View(nameof(Fake));
            }
        }

       


        // GET: JobSeekers/Create
        public IActionResult Registeruser()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser([Bind("JSId,Name,City,Email,Password,Pincode,Mobile,Dob,Gender,Ent_date")] JobSeeker jobSeeker)
        {
            var query = from p in _context.JobSeekers
                        where p.Email == jobSeeker.Email
                        select p;
            var id = query.FirstOrDefault();

            if (id == null)
            {
                if (ModelState.IsValid)
                {
                    // var crypto = new SimpleCrypto.PBKDF2();
                    //var encrypPass = crypto.Compute(jobSeeker.Password);
                    _context.Add(jobSeeker);


                    await _context.SaveChangesAsync();
                    ModelState.Clear();

                    return RedirectToAction(nameof(JobSeekerLogin));


                }
                return View(nameof(Fake));

            }
            else
            {
                return View(nameof(Fake));
            }
        }

        public async Task<IActionResult> Update_Password( JobSeeker seeker)
        {

            var email = HttpContext.Session.GetString(Email);
            ViewBag.Name = email;

            using (_context)
            {
                var query = from p in _context.JobSeekers
                            where p.Email == email
                            select p;
                var id = query.Single();
                

                ViewBag.Id1 = id.JSId;

                var entity = _context.JobSeekers.Find(id.JSId);

                if (entity != null)
                {
                    
                    _context.Update(seeker);
                    await _context.SaveChangesAsync();
                    ViewBag.sta = "Pass";
                    return View();
                }

                return View();
            }
            
            
        }

        public IActionResult Search1()
        {
            return View();
        }

        public IActionResult FindJob(string Skill, string Job_Cat)
        {

            String connectionString = "Data Source = MANAN_WORKSTATI; Initial Catalog = JobSearch; User ID = root; Password = root";


            var model = new List<PostedJob>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String sql = " SELECT * FROM postedJobs WHERE Skill=@Skill AND Job_Cat=@Job_Cat";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Skill", Skill);
                cmd.Parameters.AddWithValue("@Job_Cat", Job_Cat);





                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var postedJob = new PostedJob();
                    postedJob.JobId = (int)rdr["JobId"];
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

        public object Apply(PostedJob job)
        {


            using (_context)
            {
                var recid = job.RecId;
                var jid = job.JobId;

                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.JobSeekers
                            where p.Email == email
                            select p;
                var id = query.Single();
                var jsid = id.JSId;

                var query1 = from p in _context.postedJobs
                             where p.JobId == jid
                             select p;
                var id1 = query1.Single();

                var query2 = from p in _context.appliedJobs
                             where p.JobId == jid
                             select p;
                var id2 = query2.FirstOrDefault();
               

               if (id2 != null)
                {
                    return View(nameof(Error));
                }
                else
                {



                    AppliedJob appliedJob = new AppliedJob();
                    appliedJob.JobId = jid;
                    appliedJob.JSId = jsid;
                    appliedJob.RecId = recid;
                    appliedJob.Job_Tit = id1.Job_Tit;
                   
                    if (ModelState.IsValid)
                    {
                        //_context.Entry<PostedJob>(job).State = EntityState.Detached;
                        _context.Add(appliedJob);
                        _context.SaveChanges();
                        return View(nameof(Search1));
                    }



                    return View(nameof(Success));
                }
            }
        }
        public IActionResult Success()
        {
            return View();
        }

        public IActionResult appliedjobs()
        {
            using (_context)
            {
               
                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.JobSeekers
                            where p.Email == email
                            select p;
                var id = query.Single();
                var jsid = id.JSId;

                AppliedJobDetails appliedJobDetails = new AppliedJobDetails();
                appliedJobDetails.details = (from p in _context.appliedJobs
                            join e in _context.recruiters on p.RecId equals e.RecId
                                             where p.JSId==jsid
                            select new AppliedJobDetails()
                            {
                                ComapanyName = e.CName,
                                Job_Title = p.Job_Tit,
                                Ent_date = p.Ent_date
                            }).ToList();



              
                return View(appliedJobDetails);
            }
        }

        public IActionResult JsAccount()
        {
            using (_context)
            {

                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.JobSeekers
                            where p.Email == email
                            select p;
                var id = query.Single();
                var jsid = id.JSId;

                JsAccount account = new JsAccount();
                account.js = (from p in _context.JobSeekers
                              join e in _context.eduProfiles on p.JSId equals e.JsId
                              where p.JSId==jsid
                              select new JsAccount
                              {
                                  JsName = p.Name,
                                  City = p.City,
                                  Gender = p.Gender,
                                  Email = p.Email,
                                  Degree = e.Degree,
                                  Category=e.Category,
                                  CollegeName=e.CollegeName,
                                  Mobile=p.Mobile,
                                  CGPA=e.CGPA,
                                  Experiance=e.Experiance,
                                  Skill=e.Skill,
                                  PassingYear=e.Passing_Year

                              }).ToList();




                return View(account);
            }
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Fake()
        {
            return View();
        }




    }
}