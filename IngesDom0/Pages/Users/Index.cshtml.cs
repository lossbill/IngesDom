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
    public class IndexModel : PageModel
    {
        private readonly IngesDom0.Data.IngesDom0Context _context;

        public IndexModel(IngesDom0.Data.IngesDom0Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
