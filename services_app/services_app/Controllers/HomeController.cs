using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using services_app.Services;
using services_app.Models;

namespace services_app.Controllers
{
    [Route("api/[controller]")] //https://localhost:7700/api/home
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IServiceUser? _serviceUser;
        private readonly UserContext? _context;
        public HomeController(IServiceUser serviceUser, UserContext? context)
        {
            _serviceUser = serviceUser;
            _context = context;
            _serviceUser.Db = _context;
        }
        //https://localhost:7700/api/home
        [HttpGet]
        public JsonResult Get() => Json(_serviceUser?.Read());
        
        [HttpGet("{id}")]
        public JsonResult GetUser(int id) => Json(_serviceUser?.GetUserById(id));
        [HttpPost]
        public JsonResult PostUser(User user) => Json(_serviceUser?.Create(user));
        [HttpPut]
        public JsonResult PutUser(User user) => Json(_serviceUser?.Update(user));
        [HttpDelete("{id}")]
        public void DeleteUser(int id) => _serviceUser?.Delete(id);
    }
}
