using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Infrastructure.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        { 

        }
        public DbSet<School> Schools { get; set; }
    }
}
