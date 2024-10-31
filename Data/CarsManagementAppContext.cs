using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarsManagementApp.Model;

namespace CarsManagementApp.Data
{
    public class CarsManagementAppContext : DbContext
    {
        public CarsManagementAppContext (DbContextOptions<CarsManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarsManagementApp.Model.Cars> Cars { get; set; } = default!;
    }
}
