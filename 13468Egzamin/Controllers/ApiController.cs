using _13468Egzamin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13468Egzamin.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private List<Class> Lista;

        public ApiController()
        {
            Lista = new List<Class>();
            {
                new Class() { Id = 1, title = "AAAA", author = "BBBB", price = "100" };
                new Class() { Id = 2, title = "CCCC", author = "DDDD", price = "50" };
                new Class() { Id = 3, title = "EEEE", author = "FFFF", price = "10" };
            };

        }
        [HttpGet]
        public ActionResult<IEnumerable<Class>> GetCard()
        {
            return Lista.ToList();
        }

       
    }
}
