using Microsoft.AspNetCore.Mvc;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Users.UserInputModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WalletProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }


        // GET api/<UserController>/5
        [HttpGet("{name}")]
        public async Task GetFirstName([FromBody]String name)
        {
             await _userLogic.GetAsync(name);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task Post([FromBody] UserInputModel userInputModel)
        {
           await _userLogic.CreateAsync(userInputModel);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody])
        {
            

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{name}")]
        public void Delete([FromBody]string name)
        {
             _userLogic.Delete(name);
        }
    }
}
