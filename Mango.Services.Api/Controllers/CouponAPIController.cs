using Mango.Services.CouponApi.Data;
using Mango.Services.CouponApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CouponAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
