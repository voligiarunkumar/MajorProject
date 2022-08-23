#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using LMS.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LMS.Web.Data
{
    public class MvcToDoListContext : IdentityDbContext
    {
        public DbSet<ToDoList> ToDoList { get; set; }
        
        public MvcToDoListContext (DbContextOptions<MvcToDoListContext> options)
            : base(options)
        {
        }

        
    }
}
