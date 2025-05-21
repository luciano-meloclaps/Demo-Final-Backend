using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Product?  Get(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }
    }
}
