using Multihop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccsessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCustomerManager : ICargoCustomerService
    {
        private readonly ICargoCustomerDal _cargoCustomerDal;
        public CargoCustomerManager(ICargoCustomerDal cargoCustomerDal)
        {
            _cargoCustomerDal = cargoCustomerDal;
        }

        public void Delete(CargoCustomer entity)
        {
            _cargoCustomerDal.Delete(entity);
        }

        public List<CargoCustomer> GetAll()
        {
            return _cargoCustomerDal.GetAll();
        }

        public CargoCustomer GetById(int id)
        {
            return _cargoCustomerDal.GetById(id);
        }

        public void Insert(CargoCustomer entity)
        {
            _cargoCustomerDal.Insert(entity);
        }

        public void Update(CargoCustomer entity)
        {
            _cargoCustomerDal.Update(entity);
        }
    }
}
