using API_StoresWeb.Models;
using API_StoresWeb.Repositories;
using API_StoresWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_StoresWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(ILogger<UsersController> logger, IUsers users) : ControllerBase
    {
        private readonly ILogger<UsersController> _logger = logger;
        private readonly IUsers _users = users;

        [HttpGet(Name = "users")]
        public List<UsersModel> Get()
        {
            List<UsersModel> users = new List<UsersModel>();
            users = _users.findAllUsers();
            return users;
        }
    }
}
