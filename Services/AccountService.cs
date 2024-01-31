using Plants_Api.Interfaces.AccountInterfaces;
using Plants_Api.Interfaces.UserInterfaces;

namespace Plants_Api.Services
{
    public class AccountService : IAccountService
    {
        public AccountService() { }

        private readonly IAccountRepository _accountRepository;
     
        public bool Login(string userName)
        {
           return _accountRepository.Login(userName);
        }
    }
}
