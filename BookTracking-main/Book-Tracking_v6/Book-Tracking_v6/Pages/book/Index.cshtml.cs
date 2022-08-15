using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCatelog.Data;
using Book_Tracking_v6.Models;

namespace Book_Tracking_v6.Pages.book
{
    public class IndexModel : PageModel
    {
        private readonly BookCatelog.Data.BookCatelogContext _context;

        public IndexModel(BookCatelog.Data.BookCatelogContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
