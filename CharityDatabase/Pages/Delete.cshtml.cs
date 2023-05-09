using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityDatabase.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CharityDatabase.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly CharitySystemContext _context = new CharitySystemContext();
        public Needee needeeToDelete = null;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string id = Request.Query["Id"].ToString();
            if (!string.IsNullOrEmpty(id))
            {
                int idToDelete = Convert.ToInt32(id);
                needeeToDelete = _context.Needees.FirstOrDefault(n => n.Id == idToDelete);
                if(needeeToDelete != null)
                {
                    try
                    {
                        _context.Needees.Remove(needeeToDelete);
                        _context.SaveChanges();
                        ViewData["Success"] = "عملیات حذف مددجوی زیر با موفقیت انجام شد\n" + needeeToDelete.FirstName+" "+needeeToDelete.LastName;
                    }
                    catch(Exception ex)
                    {
                        ViewData["Error"] += "عملیات حذف با مشکل مواجه شد\n" + ex.Message;
                    }
                }
                else
                {
                    ViewData["Error"] += "مددجویی با این شناسه یافت نشد";
                }
            }
        }
    }
}
