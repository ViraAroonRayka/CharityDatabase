using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityDatabase.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CharityDatabase.Pages
{
    public class NeedeesModel : PageModel
    {
        private readonly CharitySystemContext _context = new CharitySystemContext();
        public List<Needee> needees;
        public NeedeesModel()
        {
            needees = _context.Needees.OrderBy(n=>n.FirstName).ToList();
        }
        public void OnGet()
        {
        }
    }
}
