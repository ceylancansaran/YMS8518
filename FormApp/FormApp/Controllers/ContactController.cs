using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Send([FromBody]FormApp.Data.ContactSendDto contactSendDto)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(error: "Hayırdır");
            }
            return new JsonResult("ok");
        }
    }
}