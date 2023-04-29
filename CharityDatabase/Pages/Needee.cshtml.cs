using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CharityDatabase.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string firstName = Request.Form["FirstNameTextBox"];
            string lastName = Request.Form["LastNameTextBox"];
            string nationalCode = Request.Form["NationalCodeTextBox"];

            ViewData["NeedeeInfo"] = firstName + " " + lastName + " کد ملی " + nationalCode;
        }
    }
}
