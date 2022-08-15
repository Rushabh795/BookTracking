using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrack.Models;

namespace Bookcatalog.Data
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext (DbContextOptions<BookCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrack.Models.Book> Book { get; set; }
    }
}
