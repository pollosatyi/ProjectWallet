using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;

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
        public async Task<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BankAccountController>/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return "value";
        }

        // POST api/<BankAccountController>
        [HttpPost]
        public async Task Post([FromBody] BankAccountModel bankAccountModel)
        {
           await _bankAccountLogic.CreateAsync(bankAccountModel);

        }

        // PUT api/<BankAccountController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankAccountController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
        }
    }
}
