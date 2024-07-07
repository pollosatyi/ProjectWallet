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
        private readonly ILogger<UserController> _logger;

        public UserController(IUserLogic userLogic, ILogger<UserController> logger)
        {
            _userLogic = userLogic;
            _logger = logger;
        }


        //работает, но метод под вопросом
        [HttpGet("name/{name}")]
        public async Task<User> GetUserByName(string name)
        {
            _logger.LogInformation("ошибка в UserController метод GetUserByName");
            return await _userLogic.GetAsync(name);
        }


        //работает
        [HttpGet("id/{id}")]
        public async Task<User> GetUserById(Guid id)
        {
            _logger.LogDebug("ошибка в UserController метод GetUserById");
            return await _userLogic.GetUserAsync(id);
        }


        // POST api/<UserController>
        //работает
        [HttpPost]
        public async Task PostUserAsync([FromBody] UserInputModel userInputModel)
        {
            _logger.LogError("ошибка в UserController метод PostUserAsync");
            await _userLogic.CreateAsync(userInputModel);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task PutUserAsync(Guid id, [FromBody] UserUpdateModel userUpdateModel)
        {
            _logger.LogError("ошибка в UserController метод PutUserAsync");
            await _userLogic.UpdateAsync(id, userUpdateModel);

        }

        // DELETE api/<UserController>/5
        [HttpDelete("name/{name}")]
        public async Task DeleteUserByName([FromBody] string name)
        {
            _logger.LogError("ошибка в UserController метод DeleteUserByName");
            await _userLogic.Delete(name);
        }
    }
}
