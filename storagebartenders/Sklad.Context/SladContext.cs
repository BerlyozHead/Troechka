using Microsoft.EntityFrameworkCore;
using Sklad.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context
{
    internal class SladContext : DbContext, 
    {
        private DbSet<Postavshik> postavshiks { get; set; }
        private DbSet<Tovar> tovars { get; set; }

        private DbSet<Vedomost> vedomosts { get; set; }

        public DbSet<Postavshik> Postavshiks => postavshiks;

        public DbSet<Tovar> Tovars => tovars;

        public DbSet<Vedomost> Vedomosts => vedomosts;

    }
}