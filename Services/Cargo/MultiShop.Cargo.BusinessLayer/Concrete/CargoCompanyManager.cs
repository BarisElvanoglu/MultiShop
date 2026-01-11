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
    public class CargoCompanyManager : ICargoCompanyService
    {
        private readonly ICargoCompanyDal _cargoCompanyDal;

        public CargoCompanyManager(ICargoCompanyDal cargoCompanyDal)
        {
            _cargoCompanyDal = cargoCompanyDal;
        }

        public void Delete(CargoCompany obj)
        {
            _cargoCompanyDal.Delete(obj);
        }

        public List<CargoCompany> GetAll()
        {
            return _cargoCompanyDal.GetAll();
        }

        public CargoCompany GetById(int id)
        {
            return _cargoCompanyDal.GetById(id);
        }

        public void Insert(CargoCompany obj)
        {
            _cargoCompanyDal.Insert(obj);
        }

        public void Update(CargoCompany obj)
        {
            _cargoCompanyDal.Update(obj);
        }
    }
}
