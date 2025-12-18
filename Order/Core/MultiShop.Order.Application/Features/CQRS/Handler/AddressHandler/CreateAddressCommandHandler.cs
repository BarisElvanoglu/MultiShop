using MultiShop.Order.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShot.Order.Applicatinon.Entities;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;

namespace MultiShop.Order.Application.Features.CQRS.Handler.AddressHandler
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;   
        
        public CreateAddressCommandHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }
        
        public async Task Handle(CreateAddressCommand address)
        {
           
            await _addressRepository.CreateAsync(new Address
            {
                UserId = address.UserId,
                City = address.City,
                District = address.District,
                Detail = address.Detail
            }); 
        }
    }
}
