using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestFoodOrder.Services;

namespace TestFoodOrder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly IPriceCalculation _priceCalculation;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IPriceCalculation priceCalculation)
        {
            _logger = logger;
            _priceCalculation = priceCalculation;
        }

        [HttpPost("ItemTotal")]
        public async Task<double> ItemTotalPrice(List<Item> item)
        {
            return await _priceCalculation.ItemTotalPrice(item);
        }
    }
}
