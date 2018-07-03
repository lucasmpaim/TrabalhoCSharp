using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCSharp.Model.Repostiory
{
    interface IRepository<T> where T : IEntity
    {
        T Add(T item);
        T FindById(int id);
        List<T> FetchAll();
        IQueryable<T> Query { get; }
        T Remove(T item);
        T Remove(int id);

        void Edit(T item);
    }
}
