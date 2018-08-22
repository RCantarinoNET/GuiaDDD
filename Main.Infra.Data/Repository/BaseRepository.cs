using Main.Domain.Entities;
using Main.Domain.Interfaces;
using Main.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Main.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private SqlContext context = new SqlContext();

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}