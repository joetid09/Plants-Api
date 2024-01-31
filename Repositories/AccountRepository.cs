using Plants_Api.Interfaces.AccountInterfaces;

namespace Plants_Api.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository() { }
        //TODO: currently just for testing the endpoint call for logging in
        //this will be updated once a password/auth policy is decided on
        public bool Login(string userName) {  return true; }
    }
}
