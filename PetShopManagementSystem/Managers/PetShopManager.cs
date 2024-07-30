using Microsoft.EntityFrameworkCore;
using PetShopManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Managers
{
    public class PetShopManager : IGenericRepository<T>
    {
        private readonly PetShopContext _context;
        public DbSet<T> Entity {  get; set; }
        public GenericRepository()
        {
            _context = new PetShopContext();
            Entity = _context.Set<T>();

        }
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }


}
