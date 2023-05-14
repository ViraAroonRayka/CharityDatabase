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
        public List<Db.Needee> needees;
        public NeedeesModel()
        {
            needees = _context.Needees.OrderBy(n=>n.FirstName).ToList();
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string searchTerm = Request.Form["SearchTextBox"].ToString();
            try
            {
                needees = search(searchTerm);
            }
            catch(Exception ex)
            {
                ViewData["Error"] += ex.Message;
            }
        }
        public List<Db.Needee> search(string searchTerm)
        {
            if (_context != null)
            {
                try
                {
                    needees = _context.Needees.Where(n => n.FirstName.Contains(searchTerm) ||
                    n.LastName.Contains(searchTerm) || n.NationalCode.Contains(searchTerm)).ToList();
                }
                catch(Exception ex)
                {
                    throw new Exception("جستجو در پایگاه داده با خطا مواجه شد");
                }
            }
            else
            {
                throw new Exception("ارتباط با پایگاه داده میسر نشد");
            }
            return needees;
        }
    }
}
