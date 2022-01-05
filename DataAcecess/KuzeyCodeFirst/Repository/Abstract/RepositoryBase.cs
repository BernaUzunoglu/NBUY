using KuzeyCodeFirst.Data;
using KuzeyCodeFirst.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyCodeFirst.Repository
{
    public abstract class RepositoryBase<T, TId> : IRepository<T, TId> where T : BaseEntity, new()// new() default ctor ile çalış
    {
        public DbSet<T> Table { get; protected set; }
        public RepositoryBase()
        {
            _context = new KuzeyContext();
            Table = _context.Set<T>();// context içerisindeki referansı vermek için set kullandık.
        }


        protected KuzeyContext _context;
        
        public virtual void Add(T entity, bool isSaveLater = false)
        {
          Table.Add(entity);
            if (!isSaveLater)
                this.Save();
        }

        public virtual T GetById(TId id)
        {
            return Table.Find(id);
        }
        public virtual IQueryable<T> GetAll(Func<T, bool> predicate = null)
        {
            return predicate == null ?Table: Table.Where(predicate).AsQueryable();
        }

        public virtual IQueryable<T> Get(string[] includes,Func<T, bool> predicate = null)
        {
            IQueryable<T> query = Table;
            foreach (var include in includes )
            {
                query = Table.Include(include);
            }
            return predicate == null ? Table : Table.Where(predicate).AsQueryable();
        }


        public virtual void Remove(T entity, bool isSaveLater = false)
        {
            Table.Remove(entity);
            if (!isSaveLater)
                this.Save();
        }

        public virtual int Save()
        {
            return _context.SaveChanges();
        }

        public virtual void Update(T entity, bool isSaveLater = false)// kullanım amacına uymaz ise uyacak şekilde değiştirilme imkanı için virtual 
        {
            Table.Update(entity);
            if (!isSaveLater)
                this.Save();
        }
    }
}
