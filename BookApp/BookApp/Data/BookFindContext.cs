using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookApp.Model;

namespace Book.Data
{
    public class BookFindContext : DbContext
    {
        public BookFindContext (DbContextOptions<BookFindContext> options)
            : base(options)
        {
        }

        public DbSet<BookApp.Model.Book> Book { get; set; } = default!;
    }
}
