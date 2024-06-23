using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;

namespace WalletProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private IBankAccountLogic _bankAccountLogic;

        public BankAccountController(IBankAccountLogic bankAccountLogic)
        {
            _bankAccountLogic = bankAccountLogic;
        }

        // GET: api/<BankAccountController>
        [HttpGet]
        public async Task<BankAccount> Get(Guid id)
        {
            return await _bankAccountLogic.GetAsync(id);
        }

        // GET api/<BankAccountController>/5
        //[HttpGet("{id}")]
        //public async Task<string> Get(int id)
        //{
        //    return "value";
        //}

        //работает
        [HttpPost]
        public async Task Post([FromBody] BankAccountModel bankAccountModel)
        {
           await _bankAccountLogic.CreateAsync(bankAccountModel);

        }

        // PUT api/<BankAccountController>/5
        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] double balance)
        {
            await _bankAccountLogic.PutAsync(id,balance);
        }

        // DELETE api/<BankAccountController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
        }
    }
}
