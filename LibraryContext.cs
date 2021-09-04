using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using qrattend.Entities;
using qrattend.Repository.Contract;
using qrattend.Repository.Implementation;
namespace qrattend
{
  public class LibraryContext:DbContext{  
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)  
        {  
            Database.Migrate();  
        }  

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Roster> Rosters { get; set; }
        public DbSet<Student> Students { get; set; }
        public LibraryContext(DbContextOptions<LibraryContext> options, bool testing):base(options)  
        {  
        } 

    } 
}