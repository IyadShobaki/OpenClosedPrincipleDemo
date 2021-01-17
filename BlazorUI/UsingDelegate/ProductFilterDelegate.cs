using BlazorUI.Contracts;
using BlazorUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.UsingDelegate
{
    public class ProductFilterDelegate
    {
        public IEnumerable<Product> GetFilteredProducts(IEnumerable<Product> products,ISpecification<Product> specification,
            Func<IEnumerable<Product>, ISpecification<Product>, IEnumerable<Product>> filterHandler)
        {
            return filterHandler(products, specification);
        }
    }
}
