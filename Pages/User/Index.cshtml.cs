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
    public class IndexModel : PageModel
    {
        private readonly CRUD_Students.Data.CRUD_StudentsContext _context;

        public IndexModel(CRUD_Students.Data.CRUD_StudentsContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
