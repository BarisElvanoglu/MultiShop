using MultiShop.Cargo.DataAccsessLayer.Abstract;
using MultiShop.Cargo.DataAccsessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccsessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly CargoContext _context;

        public GenericRepository(CargoContext context)
        {
            _context = context;
        }

        public void Delete(T obj)
        {
            var values = _context.Set<T>().Find(obj);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            var values = _context.Set<T>().ToList();
            return values;
        }

        public T GetById(int id)
        {
            var value = _context.Set<T>().Find(id);
            return value;
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();
        }
    }
}
