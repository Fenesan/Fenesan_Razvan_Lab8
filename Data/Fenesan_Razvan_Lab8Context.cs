using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fenesan_Razvan_Lab8.Models;

namespace Fenesan_Razvan_Lab8.Data
{
    public class Fenesan_Razvan_Lab8Context : DbContext
    {
        public Fenesan_Razvan_Lab8Context (DbContextOptions<Fenesan_Razvan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fenesan_Razvan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Fenesan_Razvan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Fenesan_Razvan_Lab8.Models.Category> Category { get; set; }
    }
}
