using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarsManagementApp.Data;
using CarsManagementApp.Model;

namespace CarsManagementApp.Pages.Car
{
    public class IndexModel : PageModel
    {
        private readonly CarsManagementApp.Data.CarsManagementAppContext _context;

        public IndexModel(CarsManagementApp.Data.CarsManagementAppContext context)
        {
            _context = context;
        }

        public IList<Cars> Cars { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
