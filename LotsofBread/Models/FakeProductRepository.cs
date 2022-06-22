﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsofBread.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Ciabatta", Price = 25 },
            new Product { Name = "Idk Bread", Price = 179 },
            new Product { Name = "Some type of bread", Price = 95 }
        };
    }
}
