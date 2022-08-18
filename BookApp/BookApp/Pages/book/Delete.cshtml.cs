using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookApp.Model;
using BookCatelog.Db;

namespace BookApp.Pages.book
{
    public class DeleteModel : PageModel
    {
        private readonly BookCatelog.Db.BookContext _context;

        public DeleteModel(BookCatelog.Db.BookContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BookModel BookModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookModel == null)
            {
                return NotFound();
            }

            var bookmodel = await _context.BookModel.FirstOrDefaultAsync(m => m.id == id);

            if (bookmodel == null)
            {
                return NotFound();
            }
            else 
            {
                BookModel = bookmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.BookModel == null)
            {
                return NotFound();
            }
            var bookmodel = await _context.BookModel.FindAsync(id);

            if (bookmodel != null)
            {
                BookModel = bookmodel;
                _context.BookModel.Remove(BookModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
