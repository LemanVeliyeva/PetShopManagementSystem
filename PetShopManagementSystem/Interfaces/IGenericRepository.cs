using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Interfaces
{
    public interface IGenericRepository<T> where T : class,new()
    {
       Task<IEnumerable<T>> GetAllAsync();
       Task Add(T entity);
       void Update(T entity);
       Task<T> GetById(int id);
       Task SaveChangesAsync();

    }

   

 
}
