using System;
using System.ComponentModel.DataAnnotations;
namespace Book_Tracking_v6.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [Range(1, 10, ErrorMessage = "Rating should be between 1 to 10")]
        public int Rating { get; set; }
    }
}

