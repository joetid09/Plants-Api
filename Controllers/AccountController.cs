using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plants_Api.Interfaces.AccountInterfaces;
using Plants_Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Plants_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        // POST api/<AccountController>
        //this will be refactored once requirements are decided on for password/auth 
        //[HttpPost]

        // GET: api/PlantDetails/5
        [HttpGet("{id}")]
        public ActionResult<bool> Login(string username)
        {
            bool authorized = _accountService.Login(username);
            return _accountService.Login(username);
        }
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
