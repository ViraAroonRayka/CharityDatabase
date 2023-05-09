using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityDatabase.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CharityDatabase.Pages
{
    public class Index1Model : PageModel
    {
        CharitySystemContext _context = new CharitySystemContext();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string firstName = Request.Form["FirstNameTextBox"];
            string lastName = Request.Form["LastNameTextBox"];
            string nationalCode = Request.Form["NationalCodeTextBox"];
            string gender = Request.Form["Gender"];

            ViewData["NeedeeInfo"] = firstName + " " + lastName + " کد ملی " + nationalCode;
            Needee needee = new Needee()
            {
                FirstName = firstName,
                LastName = lastName,
                NationalCode = nationalCode,
                Gender = gender,

            };

            _context.Needees.Add(needee);
            _context.SaveChanges();
        }
    }
}
