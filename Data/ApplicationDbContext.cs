using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using testDemo.Models;

namespace testDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<testDemo.Models.Question> Question { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }


    }
}
