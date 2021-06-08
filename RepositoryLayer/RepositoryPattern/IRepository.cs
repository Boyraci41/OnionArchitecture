using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.RepositoryPattern
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
        T Get(int Id);

    }
}
