using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fenesan_Razvan_Lab8.Data;
using Fenesan_Razvan_Lab8.Models;

namespace Fenesan_Razvan_Lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Fenesan_Razvan_Lab8.Data.Fenesan_Razvan_Lab8Context _context;

        public DetailsModel(Fenesan_Razvan_Lab8.Data.Fenesan_Razvan_Lab8Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
