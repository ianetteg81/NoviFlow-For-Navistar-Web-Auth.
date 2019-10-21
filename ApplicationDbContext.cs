using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NoviFlow_For_NaviStar_Web_Authenication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NoviFlow_For_NaviStar_Web_Authenication.Data.Departments> Departments { get; set; }
        public DbSet<NoviFlow_For_NaviStar_Web_Authenication.Data.Employees> Employees { get; set; }
    }
}