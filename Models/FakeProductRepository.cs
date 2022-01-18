using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HddStore3.Models
{
    public class FakeProductRepository /*: IProductRepository*/
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Samsung", Price = 250},
            new Product { Name = "Samsung1", Price = 160},
            new Product { Name = "Samsung2", Price = 140}
        }.AsQueryable<Product>();

    }
}
