using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IngesDom0.Data;
using IngesDom0.Models;

namespace IngesDom0.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly IngesDom0.Data.IngesDom0Context _context;

        public DetailsModel(IngesDom0.Data.IngesDom0Context context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
