using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NoviFlow_For_NaviStar_Web_Authenication.Data;

namespace NoviFlow_For_NaviStar_Web_Authenication.Pages.Depts
{
    public class DetailsModel : PageModel
    {
        private readonly NoviFlow_For_NaviStar_Web_Authenication.Data.ApplicationDbContext _context;

        public DetailsModel(NoviFlow_For_NaviStar_Web_Authenication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Departments Departments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departments = await _context.Departments.FirstOrDefaultAsync(m => m.DID == id);

            if (Departments == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
