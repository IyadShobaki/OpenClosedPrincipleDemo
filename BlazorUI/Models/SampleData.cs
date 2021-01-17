using BlazorUI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class SampleData
    {
        public List<Product> Products { get; set; }
        public IEnumerable<Product> GetProducts()
        {
            Products = new List<Product>()
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Tree", Color.Green, Size.Large),
                new Product("Banana", Color.Yellow, Size.Medium),
                new Product("Cup", Color.Red, Size.Large),
                new Product("House", Color.Blue, Size.Huge),
                new Product("Toy", Color.Red, Size.Medium),
                new Product("Shirt", Color.Blue, Size.Large),
                new Product("Door", Color.Green, Size.Large)
            };

            return Products;
        }
    }
}
