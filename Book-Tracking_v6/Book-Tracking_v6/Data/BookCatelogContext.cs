using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Tracking_v6.Models;

namespace BookCatelog.Data
{
    public class BookCatelogContext : DbContext
    {
        public BookCatelogContext (DbContextOptions<BookCatelogContext> options)
            : base(options)
        {
        }

        public DbSet<Book_Tracking_v6.Models.Book> Book { get; set; } = default!;
    }
}
