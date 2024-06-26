﻿using Microsoft.AspNetCore.Mvc;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WalletProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletLogic _walletLogic;

        public WalletController(IWalletLogic walletLogic)
        {
            _walletLogic = walletLogic;
        }
        


        //работает
        [HttpPost]
        public async Task Post([FromBody] WalletInputModel walletInputModel)
        {
            await _walletLogic.CreateAsync(walletInputModel);
        }

        //[HttpGet("{walletId1}")]
        //public async Task<Wallet> Get(Guid walletId)
        //{
        //    return await _walletLogic.GetAsync(walletId);
        //}


        [HttpGet("{walletId2}")]
        public async Task<List<BankAccount>> GetAllBankAccount(Guid walletId)
        {
            return await _walletLogic.GetListBankAccountsAsync(walletId);
        }


        // DELETE api/<WalletController>/5
        [HttpDelete("{idWallet}")]
        public async Task DeleteWallet(Guid idWallet)
        {
            await _walletLogic.Delete(idWallet);


        }
    }
}
