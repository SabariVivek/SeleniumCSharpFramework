using Framework.Core.Config;
using Framework.Core.Driver;
using Framework.Test.Pages;

namespace Framework.Test.Tests
{
    public class AccountCreation
    {
        private readonly IAccountCreationPage _accountCreationPage;
        private readonly IMyAccountPage _myAccountPage;

        public AccountCreation(IAccountCreationPage accountCreationPage, IMyAccountPage myAccountPage)
        {
            _accountCreationPage = accountCreationPage;
            _myAccountPage = myAccountPage;
        }

        [Fact]
        public void AccountCreationMethod()
        {
            _accountCreationPage.CreateAnAccount();
            _myAccountPage.AssertMyAccountPage();
        }
    }
}