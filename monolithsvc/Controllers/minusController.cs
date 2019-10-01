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
    public class minusController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<sharedMath> Get(int a, int b)
        {
            sharedMath myObj = new sharedMath();

            myObj.mathresult = myObj.minusTwoNumbers(a,b);

            return myObj;
        }

    }
}
