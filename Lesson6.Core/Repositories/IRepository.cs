using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        T Delete(int id);
        T  Update(int id,T entity);
        T Add(T entity);
        List<T> GetAll();
    }
}
