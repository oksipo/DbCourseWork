using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authresearch.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vipikayko.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {

        private ApplicationDbContext context;

        public TestController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public object Get()
        {
            return this.context.Foods.ToList();
        }
    }
}