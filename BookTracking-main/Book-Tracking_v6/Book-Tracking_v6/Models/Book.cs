using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Tracking_v6.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string description { get; set; }
        public string rate { get; set; }
        public string Category { get; set; }

    }
}

