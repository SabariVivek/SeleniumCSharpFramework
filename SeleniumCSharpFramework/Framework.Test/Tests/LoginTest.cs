using Framework.Core.Config;
using Framework.Core.Driver;
using Framework.Test.Pages;

namespace Framework.Test.Tests
{
    public class LoginTest
    {
        private readonly ILoginPage _loginPage;
        private readonly IMyAccountPage _myAccountPage;

        public LoginTest(ILoginPage loginPage, IMyAccountPage myAccountPage)
        {
            _loginPage = loginPage;
            _myAccountPage = myAccountPage;
        }

        [Fact]
        public void LoginMethod()
        {
            _loginPage.LoginMethod();
            _myAccountPage.AssertMyAccountPage();
        }
    }
}