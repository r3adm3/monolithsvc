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
        public ActionResult<SharedMath> Get(int a, int b)
        {
            SharedMath myObj = new SharedMath();

            myObj.Mathresult = myObj.MultiplyTwoNumbers(a,b);

            return myObj;
        }

    }
}
