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
    public class IndexModel : PageModel
    {
        private readonly BookCatelog.Db.BookContext _context;

        public IndexModel(BookCatelog.Db.BookContext context)
        {
            _context = context;
        }

        public IList<BookModel> BookModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookModel != null)
            {
                BookModel = await _context.BookModel.ToListAsync();
            }
        }
    }
}
