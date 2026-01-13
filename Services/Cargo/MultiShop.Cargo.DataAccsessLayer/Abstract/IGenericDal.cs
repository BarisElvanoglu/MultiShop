using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccsessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        List<T> GetAll();
        T GetById(int id);
    }
}
