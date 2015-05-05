using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Domain.Interfaces.Services
{
    public interface IService<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T Get(int Id);
        void SaveChanges();
    }
}
