using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "First Product", "Second Product" };
        }
    }
}