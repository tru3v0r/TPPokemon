using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWeb.Controllers
{
    public class HelloController : Controller
    {
        // GET: HelloController
        public EmptyResult Index()
        {
            Response.WriteAsync("<h1>Hello World</h1>");
            return new EmptyResult();
        }

    }
}
