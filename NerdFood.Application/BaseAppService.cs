using Microsoft.Practices.ServiceLocation;
using NerdFood.Domain.Interfaces.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Application
{
    public class BaseAppService
    {
        private IUnitOfWork _uow;

        public virtual void BeginTran()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.Start();
        }

        public virtual void Commit()
        {
            _uow.SaveChanges();
        }
    }
}
