namespace Framework.Test.Pages
{
    public interface ILoginPage
    {
        void LoginMethod();
    }

    public class LoginPage : ILoginPage
    {
        private readonly IDriverWait _driver;

        public LoginPage(IDriverWait driverWait)
        {
            _driver = driverWait;
        }

        private IWebElement Username => _driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement Password => _driver.FindElement(By.XPath("//input[@title='Password']"));
        private IWebElement SignIn => _driver.FindElement(By.XPath("//button[@class='action login primary']"));

        public void LoginMethod()
        {
            Username.TypeText("Username", "sabarivivek7@gmail.com");
            Password.TypeText("Password", "Sabari@123");
            SignIn.Click("Sign In");
        }
    }
}