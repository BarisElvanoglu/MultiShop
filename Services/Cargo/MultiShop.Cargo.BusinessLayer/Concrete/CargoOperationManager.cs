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
    public class CargoOperationManager : ICargoOperationService
    {
        private readonly ICargoOperationDal _cargoOperationService;
        public CargoOperationManager(ICargoOperationDal cargoOperationService)
        {
            _cargoOperationService = cargoOperationService;
        }

        public void Delete(CargoOperation entity)
        {
            _cargoOperationService.Delete(entity);
        }

        public List<CargoOperation> GetAll()
        {
            return _cargoOperationService.GetAll();
        }

        public CargoOperation GetById(int id)
        {
            return _cargoOperationService.GetById(id);
        }

        public void Insert(CargoOperation entity)
        {
            _cargoOperationService.Insert(entity);
        }

        public void Update(CargoOperation entity)
        {
            _cargoOperationService.Update(entity);
        }
    }
}
