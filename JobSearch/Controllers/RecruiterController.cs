using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace JobSearch.Controllers
{
    public class RecruiterController : Controller
    {

        private readonly OurDbContext _context;

        const string Email = "Name";

        public RecruiterController(OurDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser([Bind("RecId,CName,Address,Email,Password,Pincode,Mobile,Ent_date,City")] Recruiter recruiter)
        {
            var query = from p in _context.recruiters
                        where p.Email == recruiter.Email
                        select p;
            var id = query.FirstOrDefault();

            if (id == null)
            {
                if (ModelState.IsValid)
                {

                    _context.Add(recruiter);


                    await _context.SaveChangesAsync();
                    ModelState.Clear();

                    return RedirectToAction(nameof(Login));


                }
                return View(nameof(Fake));
            }

            return View(nameof(Fake));
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Models.Recruiter recruiter)
        {
            var account = _context.recruiters.Where(u => u.Email == recruiter.Email && u.Password == recruiter.Password).FirstOrDefault();


            if (account != null)
            {


                HttpContext.Session.SetString(Email, recruiter.Email);


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
            return RedirectToAction("Login");
        }

        public IActionResult PostJob()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> PostJob(PostedJob job)
        {
            using (_context)
            {
                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.recruiters
                            where p.Email == email
                            select p;
                var id = query.Single();

                var recid = id.RecId;

                var cname = id.CName;



                

                job.RecId = recid;
                job.CName = cname;
                if (ModelState.IsValid)
                {

                    _context.Add(job);


                    await _context.SaveChangesAsync();

                    return View(nameof(Home));


                }
                return View(nameof(Login));
            }
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult RecRegister()
        {
            return View();
        }


        public IActionResult Candidates()
        {
            using (_context)
            {

                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.recruiters
                            where p.Email == email
                            select p;
                var id = query.Single();
                var recid = id.RecId;




                JsAccount account = new JsAccount();
                account.js = (from p in _context.JobSeekers
                              join e in _context.eduProfiles on p.JSId equals e.JsId
                              join m in _context.appliedJobs on p.JSId equals m.JSId
                              where m.RecId == recid
                              select new JsAccount
                              {
                                  JsName = p.Name,
                                  City = p.City,
                                  Gender = p.Gender,
                                  Email = p.Email,
                                  Degree = e.Degree,
                                  Category = e.Category,
                                  CollegeName = e.CollegeName,
                                  Mobile = p.Mobile,
                                  CGPA = e.CGPA,
                                  Experiance = e.Experiance,
                                  Skill = e.Skill,
                                  PassingYear = e.Passing_Year,
                                  Job_Title = m.Job_Tit,
                                  AppOn = m.Ent_date

                              }).ToList();




                return View(account);
            }
        }

        public IActionResult PostedJobs()
        {
            using (_context)
            {
                var email = HttpContext.Session.GetString(Email);
                var query = from p in _context.recruiters
                            where p.Email == email
                            select p;
                var id = query.Single();
                var recid = id.RecId;

                var model = new List<PostedJob>();
                model = (from p in _context.postedJobs
                         where p.RecId == recid
                         select new PostedJob
                         {
                             JobId = p.JobId,
                             CName = p.CName,
                             Job_Cat = p.Job_Cat,
                             Job_Tit = p.Job_Tit,
                             Ent_date = p.Ent_date,
                             Vacancy = p.Vacancy,
                             Skill = p.Skill
                         }
                            ).ToList();


                return View(model);
            }
        }

        public IActionResult Fake()
        {
            return View();
        }

        public IActionResult removepost(PostedJob job)
        {
            ViewBag.jid = job.JobId;

            var jobid = job.JobId;

            using (_context)
            {
                PostedJob raw = (from c in _context.postedJobs
                                 where c.JobId == jobid
                                 select c).FirstOrDefault();
                _context.postedJobs.Remove(raw);
                _context.SaveChanges();
                return RedirectToAction("PostedJobs");
            }



            // return View(nameof(PostedJobs));

        }
    }

}