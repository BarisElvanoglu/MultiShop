using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShot.Order.Applicatinon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handler.AddressHandler
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;  
        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddressQueryResul>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAddressQueryResul
            {
                AddressId = x.AddressId,
                UserId = x.UserId,
                City = x.City,
                District = x.District,
                Detail = x.Detail
            }).ToList();
        }   
    }
}
