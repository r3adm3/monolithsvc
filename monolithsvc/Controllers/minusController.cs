using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace monolithsvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class minusController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<int> Get(int a, int b)
        {
            return (a - b);
        }

    }
}
