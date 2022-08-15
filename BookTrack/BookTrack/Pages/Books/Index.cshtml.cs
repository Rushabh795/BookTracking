using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrack.Models;
using Bookcatalog.Data;

namespace BookTrack.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Bookcatalog.Data.BookCatalogContext _context;

        public IndexModel(Bookcatalog.Data.BookCatalogContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
