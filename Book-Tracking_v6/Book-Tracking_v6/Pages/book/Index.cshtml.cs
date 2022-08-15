using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Book_Tracking_v6.Models;
using Bookcatelog.Data;

namespace Book_Tracking_v6.Pages.book
{
    public class IndexModel : PageModel
    {
        private readonly Bookcatelog.Data.BookCatalogContext _context;

        public IndexModel(Bookcatelog.Data.BookCatalogContext context)
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
