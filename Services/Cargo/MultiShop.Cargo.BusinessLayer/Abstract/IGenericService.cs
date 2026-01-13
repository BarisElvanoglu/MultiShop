using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        List<T> GetAll();
        T GetById(int id);
    }
}
