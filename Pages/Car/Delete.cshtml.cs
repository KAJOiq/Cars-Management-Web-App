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
    public class DeleteModel : PageModel
    {
        private readonly CarsManagementApp.Data.CarsManagementAppContext _context;

        public DeleteModel(CarsManagementApp.Data.CarsManagementAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cars Cars { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

            if (cars == null)
            {
                return NotFound();
            }
            else
            {
                Cars = cars;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars.FindAsync(id);
            if (cars != null)
            {
                Cars = cars;
                _context.Cars.Remove(Cars);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
