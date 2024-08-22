using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernox.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> QueryAllAsync();
        Task<T?> QueryOnByIdAsync(Guid id);
        void InsertAsync(T entity);
        void UpdateAsync(T entity);
    }
}
