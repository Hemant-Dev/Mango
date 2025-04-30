using Mango.Services.ShoppingCartAPI.Models.Dto;
using System.Runtime.Serialization;

namespace Mango.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
