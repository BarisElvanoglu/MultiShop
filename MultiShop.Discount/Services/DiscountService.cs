using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context=context;
        }
        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons (Code,Rate,IsActive,ValidDate) values (@Code,@Rate,@IsActive,@ValidDate)";  
            var parameters = new DynamicParameters();
            parameters.Add("@Code", createCouponDto.Code);   
            parameters.Add("@Rate", createCouponDto.Rate);
            parameters.Add("@IsActive", createCouponDto.IsActive);
            parameters.Add("@ValidDate", createCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "delete from Coupons where CouponId=@CouponId";
            var Parameters = new DynamicParameters();
            Parameters.Add("@CouponId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, Parameters);
            }
        }

        public async Task<List<ResultCouponDto>> GetAllCouponsAsync()
        {
            string query = "select * from Coupons";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCouponDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCouponDto> GetByIdCouponAsync(int couponId)
        {
            string query = "select * from Coupons where CouponId=@CouponId";
            var parameters = new DynamicParameters();
            parameters.Add("@CouponId", couponId);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdCouponDto>(query);
                return values;
            }
        }

        public async Task UpdateCouponDto(UpdateCouponDto updateCouponDto)
        {
            string query = "update Coupons set Code = @code, Rate=@rate,IsActive = @isActive, ValidDate = @valiDate Where CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@Code", updateCouponDto.Code);
            parameters.Add("@Rate", updateCouponDto.Rate);
            parameters.Add("@IsActive", updateCouponDto.IsActive);
            parameters.Add("@ValidDate", updateCouponDto.ValidDate);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
