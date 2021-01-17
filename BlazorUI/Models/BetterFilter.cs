using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var i in items)
            {
                if (specification.IsSatisfied(i))
                {
                    yield return i;
                }
            }
        }
    }
}
