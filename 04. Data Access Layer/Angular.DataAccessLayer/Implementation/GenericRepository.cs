using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Angular.DataAccessLayer.Interfaces;

namespace Angular.DataAccessLayer.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MyDbContext _db = null;
        private readonly DbSet<T> _table = null;

        public GenericRepository()
        {
            this._db = DbConnection.GetContext();
            _table = _db.Set<T>();
        }

        public GenericRepository(MyDbContext db)
        {
            this._db = db;
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            if (existing != null)
                _table.Remove(existing);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
