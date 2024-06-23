using Microsoft.AspNetCore.Mvc;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserInputModels;
using WalletProject.Common.Entities.Users.UserUpdateModels;

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


        //работает, но метод под вопросом
        //[HttpGet("{name}")]
        //public async Task<User> GetFirstName(string name)
        //{
        //    return await _userLogic.GetAsync(name);
        //}


        //работает
        [HttpGet("{id}")]
        public async Task<User> GetUser(Guid id)
        {
            return await _userLogic.GetUserAsync(id);
        }


        // POST api/<UserController>
        //работает
        [HttpPost]
        public async Task Post([FromBody] UserInputModel userInputModel)
        {
            await _userLogic.CreateAsync(userInputModel);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] UserUpdateModel userUpdateModel)
        {
            await _userLogic.UpdateAsync(id, userUpdateModel);

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{name}")]
        public async Task Delete([FromBody] string name)
        {
            await _userLogic.Delete(name);
        }
    }
}
