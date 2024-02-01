using Plants_Api.Interfaces.AccountInterfaces;
using Plants_Api.Interfaces.UserInterfaces;

namespace Plants_Api.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }


        public bool Login(string userName)
        {
           return _accountRepository.Login(userName);
        }
    }
}
