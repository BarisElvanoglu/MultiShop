using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
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
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            this._repository = repository;
        }
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)   
        {
            var values = await _repository.GetByIdAsync(query.Id); 
            return new GetAddressByIdQueryResult
            {
                AddressId = values.AddressId,
                UserId = values.UserId,
                City = values.City,
                District = values.District,
                Detail = values.Detail
            };  
        }
    }
}
