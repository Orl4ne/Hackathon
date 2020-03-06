using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackthon.Common.Interfaces;
using Hackthon.Common.TransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackthon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRole userRole;

        public UserController(IUserRole userRole)
        {
            this.userRole = userRole;
        }

        [HttpPost]
        public JsonResult AddTask(TaskTO task)
        {
            return new JsonResult(userRole.AddTask(task));
        }
    }
}