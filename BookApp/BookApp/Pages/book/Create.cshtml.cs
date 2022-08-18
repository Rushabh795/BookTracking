using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookApp.Model;
using BookCatelog.Db;

namespace BookApp.Pages.book
{
    public class CreateModel : PageModel
    {
        private readonly BookCatelog.Db.BookContext _context;

        public CreateModel(BookCatelog.Db.BookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookModel BookModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BookModel == null || BookModel == null)
            {
                return Page();
            }

            _context.BookModel.Add(BookModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
