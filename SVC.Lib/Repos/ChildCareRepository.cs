using System;
using System.Collections.Generic;
using System.Text;
using SVC.Lib.Models;

namespace SVC.Lib.Repos
{
    public class ChildCareRepository : IRepository<Childcareproviders>
    {
        public readonly fy18oneweekContext _db;

        public ChildCareRepository(string conn)
        {
            _db = new fy18oneweekContext(conn);
        }

        public IEnumerable<Childcareproviders> List => _db.Childcareproviders;

        public void Add(Childcareproviders entity)
        {
            _db.Childcareproviders.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Childcareproviders entity)
        {
            _db.Childcareproviders.Remove(entity);
            _db.SaveChanges();
        }

        public Childcareproviders FindById(int Id)
        {
            return _db.Childcareproviders.Find(Id);
        }

        public void Update(Childcareproviders entity)
        {
            _db.Childcareproviders.Update(entity);
            _db.SaveChanges();
        }
    }
}
