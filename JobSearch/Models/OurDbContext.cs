using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.Models
{
    public class OurDbContext : DbContext
    {
        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {

        }

        public DbSet<JobSeeker> JobSeekers {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobSeeker>()
                .HasAlternateKey(c => c.Email)
                .HasName("AlternateKey_Email");
            modelBuilder.Entity<AppliedJob>()
                .HasAlternateKey(c => c.JobId)
                .HasName("AlternateKey");
            modelBuilder.Entity<EduProfile>()
                .HasAlternateKey(c => c.JsId)
                .HasName("AlternateKey");
        }


        public DbSet<PostedJob> postedJobs { get; set; }

        public DbSet<Recruiter> recruiters { get; set; }

        public DbSet<EduProfile> eduProfiles { get; set; }

       
        public DbSet<AppliedJob> appliedJobs { get; set; }
    }
}
