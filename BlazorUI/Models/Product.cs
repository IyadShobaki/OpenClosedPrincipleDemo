using BlazorUI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class Product
    {
        public string ProductName { get; private set; }
        public Color Color { get; private set; }
        public Size Size { get; private set; }

        public Product(string productName, Color color, Size size)
        {
            if (productName is null)
            {
                throw new ArgumentNullException(paramName: nameof(productName));
            }
            ProductName = productName;
            Color = color;
            Size = size;
        }
    }
}
