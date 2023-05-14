using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityDatabase.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CharityDatabase.Pages.Needee
{
    public class EditModel : PageModel
    {
        private readonly CharitySystemContext _context = new CharitySystemContext();
        public Db.Needee needeeToEdit;
        public EditModel()
        {
            string id = Request.Query["Id"].ToString();
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    int idToEdit = Convert.ToInt32(id);
                    needeeToEdit = _context.Needees.FirstOrDefault(n => n.Id == idToEdit);
                    if (needeeToEdit == null)
                    {
                        ViewData["Error"] += "مددجویی با این شناسه یافت نشد";
                    }
                }
                catch (Exception ex)
                {
                    ViewData["Error"] += "عملیات ویرایش با مشکل مواجه شد\n" + ex.Message;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }
        public void OnGet()
        {
            string id = Request.Query["Id"].ToString();
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    int idToEdit = Convert.ToInt32(id);
                    needeeToEdit = _context.Needees.FirstOrDefault(n => n.Id == idToEdit);
                    if (needeeToEdit == null)
                    {
                        ViewData["Error"] += "مددجویی با این شناسه یافت نشد";
                    }
                }
                catch (Exception ex)
                {
                    ViewData["Error"] += "عملیات ویرایش با مشکل مواجه شد\n" + ex.Message;
                }
                finally
                {
                    _context.Dispose();
                }
            }
        }
    }
}
