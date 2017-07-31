using System;
using System.Collections.Generic;
using System.Text;
using SVC.Lib.Models;

namespace SVC.Lib.Repos
{
    public class HealthRepository : IRepository<Providers>
    {
        public readonly fy18oneweekContext _db;

        public HealthRepository(String conn)
        {
            _db = new fy18oneweekContext(conn);
        }

        public IEnumerable<Providers> List => _db.Providers;

        public void Add(Providers entity)
        {
            _db.Providers.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Providers entity)
        {
            _db.Providers.Remove(entity);
            _db.SaveChanges();
        }

        public Providers FindById(int Id)
        {
            return _db.Providers.Find(Id);
        }

        public void Update(Providers entity)
        {
            _db.Providers.Update(entity);
            _db.SaveChanges();
        }
    }
}
