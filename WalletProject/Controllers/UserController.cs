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


        //работает
        [HttpGet("name/{name}")]
        public async Task<User> GetUserByName(string name)
        {
            
            return await _userLogic.GetAsync(name);
        }


        //работает
        [HttpGet("id/{id}")]
        public async Task<User> GetUserById(Guid id)
        {
         
            return await _userLogic.GetUserAsync(id);
        }


        
        //работает
        [HttpPost]
        public async Task PostUserAsync([FromBody] UserInputModel userInputModel)
        {
           
            await _userLogic.CreateAsync(userInputModel);
        }

        
        //работает
        [HttpPut("{id}")]
        public async Task PutUserAsync(Guid id, [FromBody] UserUpdateModel userUpdateModel)
        {
            
            await _userLogic.UpdateAsync(id, userUpdateModel);

        }

        // DELETE api/<UserController>/5

        [HttpDelete("name/{name}")]
        public async Task DeleteUserByName( string name)
        {
            await _userLogic.Delete(name);
        }
    }
}
