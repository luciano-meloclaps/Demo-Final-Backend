using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Forma de patron para interactuar con la BD  Repository
namespace Infraestructure.Repositories
{ 
    public class UserRepository
    {
        //MIN 55 Iny
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public User? Get (string name)
        {
            return _context.Users.FirstOrDefault (u => u.Name == name);
        }
    }
}
