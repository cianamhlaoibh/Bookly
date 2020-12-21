using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookly.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Genre { get; set; }
        public double Price { get; set; }
        //every book related to one book - one:many
        public String UserId { get; set; }
        public AppUser User { get; set; }
    }
}
