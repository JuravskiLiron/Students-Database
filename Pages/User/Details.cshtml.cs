using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_Students.Data;
using CRUD_Students.Model;

namespace CRUD_Students.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD_Students.Data.CRUD_StudentsContext _context;

        public DetailsModel(CRUD_Students.Data.CRUD_StudentsContext context)
        {
            _context = context;
        }

        public Users Users { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }
            else
            {
                Users = users;
            }
            return Page();
        }
    }
}
