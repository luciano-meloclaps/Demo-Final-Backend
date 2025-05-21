using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
        public Product Get(string name, int value)
        {
            return new Product() { Name = name, Value = value};
        }

    }
}

