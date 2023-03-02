using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VInternshipWebApp.Models;

namespace VInternshipWebApp.Data
{
    public class VInternshipWebAppContext : DbContext
    {
        public VInternshipWebAppContext (DbContextOptions<VInternshipWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<VInternshipWebApp.Models.Registration> Registration { get; set; } = default!;
    }
}
