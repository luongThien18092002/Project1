using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project1.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<project1.Models.Person> Person { get; set; } = default!;
        public DbSet<project1.Models.Employee> Employee { get; set; } = default!;
        public DbSet<project1.Models.HeThongPhanPhoi> HeThongPhanPhoi  { get; set; } = default!;
        public DbSet<project1.Models.DaiLy> DaiLy  { get; set; } = default!;
    }
