using System;
using System.Collections.Generic;
using System.Text;
using SVC.Lib.Models;

namespace SVC.Lib.Repos
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
}
