using System;
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrdersController : ControllerBase
    {
        public String Get()
        {
            return "Orders API";
        }
    }
}