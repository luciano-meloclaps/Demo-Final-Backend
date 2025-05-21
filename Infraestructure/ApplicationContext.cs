using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ApplicationContext : DbContext
    {
        //Esta entidad seria traducir una entidad a tabla y viceversa, la interaccion 
        public DbSet<User> Users { get; set;  }
        public DbSet<Product> Products { get; set; }

        private readonly bool isTestingEnviroment;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, bool isTestingEnviroment = false) : base(options) 
        {
            this.isTestingEnviroment = isTestingEnviroment;
        }
    }
}
