using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d2.Task3
{
    public interface IRepository<T>
    {
        public void Add(T item);
        public void Remove(T item);
        public T GetById(int id);
        public List<T> GetAll();

    }
}
