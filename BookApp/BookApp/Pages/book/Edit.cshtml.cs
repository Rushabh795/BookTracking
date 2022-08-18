using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookApp.Model;
using BookCatelog.Db;

namespace BookApp.Pages.book
{
    public class EditModel : PageModel
    {
        private readonly BookCatelog.Db.BookContext _context;

        public EditModel(BookCatelog.Db.BookContext context)
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

            var bookmodel =  await _context.BookModel.FirstOrDefaultAsync(m => m.id == id);
            if (bookmodel == null)
            {
                return NotFound();
            }
            BookModel = bookmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BookModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookModelExists(BookModel.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookModelExists(int id)
        {
          return (_context.BookModel?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
