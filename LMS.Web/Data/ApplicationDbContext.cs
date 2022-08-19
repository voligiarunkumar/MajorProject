// NOTES:
//      Please add the following NuGet packages:
//      (a) Microsoft.EntityFrameworkCore (ver 3.x)
//      (b) Microsoft.EntityFrameworkCore.SqlServer (ver 3.x)
//      (c) Microsoft.EntityFrameworkCore.Tools (ver 3.x)  -- for EF Core Data Migrations
//      Make sure all the three Nuget packages for EF Core have the same version!!!!

using LMS.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }


    }
}
