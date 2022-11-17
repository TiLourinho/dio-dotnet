using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime date)
        {
            Id = id;
            Product = product;
            Price = price;
            SaleDate = date;
        }

        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}