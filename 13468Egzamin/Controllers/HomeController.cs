using _13468Egzamin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13468Egzamin.Controllers
{
    [Route("api/Lista")]
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        
        
    }
}