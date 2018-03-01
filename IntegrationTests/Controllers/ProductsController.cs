using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationTests.Controllers
{
    public class ProductsController
    {
        [HttpGet("products")]
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {Name = "testi", Price = 10m},
                new Product {Name = "toinen", Price = 4m},
            };
        }
    }
}
