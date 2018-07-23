using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Use_Case;

namespace HiQo.StaffManagement.DAL.Services
{
    class UserService : IUserService
    {
        private IUserRepository _userRepository;



        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public TEntity GetById<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByFirstName<TEntity>(string firstName) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByLastName<TEntity>(string lastName) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByRole<TEntity>(string role) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByDepertment<TEntity>(string depertment) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByCategory<TEntity>(string category) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByPosition<TEntity>(string position) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByBirthDate<TEntity>(DateTime bithDate) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
