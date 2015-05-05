using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Interfaces.Services;
using NerdFood.Domain.Interfaces.Repository;
using NerdFood.Domain;
using NerdFood.Domain.Interfaces.Infra;


namespace NerdFood.Domain.Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository = null;
        private IUnitOfWork _uow;

        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected IRepository<T> Repository
        {
            get { return _repository; }
        }

        protected IUnitOfWork UnitOfWork
        {
            get { return _uow; }
        }

        public void Add(T entity)
        {
            Repository.Add(entity);
        }

        public void Update(T entity)
        {
            Repository.Update(entity);
        }

        public void Delete(T entity)
        {
            Repository.Delete(entity);
        }

        public List<T> GetAll()
        {
            return Repository.All().ToList();
        }

        public T Get(int Id)
        {
            return Repository.GetById(Id);

        }

        public void SaveChanges()
        {
            UnitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            Repository.Dispose();
        }
    }
}
