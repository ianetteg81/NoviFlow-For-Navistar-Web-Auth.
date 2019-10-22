using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NoviFlow_For_NaviStar_Web_Authenication.Data;

namespace NoviFlow_For_NaviStar_Web_Authenication.Pages.Emps
{
    public class IndexModel : PageModel
    {
        private readonly NoviFlow_For_NaviStar_Web_Authenication.Data.ApplicationDbContext _context;

        public IndexModel(NoviFlow_For_NaviStar_Web_Authenication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employees> Employees { get;set; }

        public async Task OnGetAsync()
        {
            Employees = await _context.Employees.ToListAsync();
        }
    }
}
