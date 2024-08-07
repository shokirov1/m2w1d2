using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d2.Task3
{
    public class InMemoryRepository<T> : IRepository<T> where T : Person
    {
        private readonly List<T> list = new List<T>();
        public void Add(T item)
        {
            try
            {
                if(item !=null)
                {
                    list.Add(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            var findById = list.FirstOrDefault(x => x.Id == id);
            return findById; 
        }

        public void Remove(T item)
        {
            var removeByItem=list.FirstOrDefault(x=>x.Id == item.Id);
            if(removeByItem != null)
            {
                list.Remove(removeByItem);
            }
            else
            {
                Console.WriteLine("list is холи");
            }
        }
    }
}
