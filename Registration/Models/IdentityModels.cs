using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Registration.Models;

namespace Registration.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<student> dbstd { set; get; }
        public DbSet<users> User { set; get; }
        public DbSet<ideaTeam> dbidea { set; get; }
        public DbSet<teamLeader> dbleader { set; get; }
        public DbSet<professor> dbpro { set; get; }
        public DbSet<idea_professor> dbIdeaPro { set; get; }
       
        public DbSet<Department> Department { set; get; }
        
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}