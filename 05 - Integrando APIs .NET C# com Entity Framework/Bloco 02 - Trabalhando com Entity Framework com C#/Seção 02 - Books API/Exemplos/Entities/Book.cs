using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public int ReleaseYear { get; set; }
        public string Publisher { get; set; }
        public double Ratings { get; set; }
        public string Synopsis { get; set; }
    }
}