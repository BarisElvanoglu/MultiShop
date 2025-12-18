using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShot.Order.Applicatinon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handler.AddressHandler
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;   

        public UpdateAddressCommandHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task Handle(UpdateAddressCommand address)
        {
            var addr = await _addressRepository.GetByIdAsync(address.AddressId);
            addr.UserId = address.UserId;
            addr.City = address.City;
            addr.District = address.District;
            addr.Detail = address.Detail;
            await _addressRepository.UpdateAsync(addr);
        }
    }
}
