using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.DB
{
    public class JobsContext : IdentityDbContext<ApplicationUser>  
    {  
        public JobsContext(DbContextOptions<JobsContext> options) : base(options)  
        {  
        }
        public DbSet<Department> Departments { get; set; }  
        public DbSet<jobs> jobs { get; set; }  
        public DbSet<Adresss> adressses { get; set; }  
        public DbSet<UserInformation> userInformation { get; set; }  
        public DbSet<ApplyJobs> ApplyJobs { get; set; }
        public DbSet<QuestionJob> questions { get; set; }
        public DbSet<Post> post { get; set; }
        public DbSet<Feeling> Feelings { get; set; }
    }  
}
