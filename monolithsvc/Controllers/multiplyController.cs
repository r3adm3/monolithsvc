using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using monolithsvc.Models;

namespace monolithsvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class multiplyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<int> Get(int a, int b)
        {
            sharedMath myObj = new sharedMath();

            var result = myObj.multiplyTwoNumbers(a,b);

            return result;
        }

    }
}
