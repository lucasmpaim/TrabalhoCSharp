using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCSharp.Model.Pojo;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.Model.Repostiory
{
    class Repository<T>: IRepository<T> where T: class, IEntity
    {

        private DatabaseContext Context { get; set; }

        public Repository()
        {
            this.Context = new DatabaseContext();
        }

        public T Add(T item)
        {
            var _item = this.Context.Set<T>().Add(item);
            Context.SaveChanges();
            return _item;
        }

        public T FindById(int id)
        {
            return this.Context.Set<T>().Find(id);
        }

        public List<T> FetchAll()
        {
            return this.Context.Set<T>().ToList();
        }

        public IQueryable<T> Query => this.Context.Set<T>();

        public T Remove(T item)
        {
            return this.Remove(item.Id);
        }

        public T Remove(int id)
        {
            var instance = this.FindById(id);
            Context.Entry(instance).State = EntityState.Deleted;

            this.Context.Set<T>().Remove(
                instance
            );
            Context.SaveChanges();

            return instance;
        }

        public void Edit(T item)
        {
            this.Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}

//Server=localhost;Database=master;Trusted_Connection=True;