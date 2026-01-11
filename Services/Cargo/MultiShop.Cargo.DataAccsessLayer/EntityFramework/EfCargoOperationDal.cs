using Multihop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.DataAccsessLayer.Abstract;
using MultiShop.Cargo.DataAccsessLayer.Concrete;
using MultiShop.Cargo.DataAccsessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccsessLayer.EntityFramework
{
    public class EfCargoOperationDal: GenericRepository<CargoOperation>, ICargoOperationDal
    {
        public EfCargoOperationDal(CargoContext context) : base(context)
        {
        }   

    }
}
