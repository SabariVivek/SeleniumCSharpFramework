using Framework.Core.Driver;
using Framework.Core.Extensions;
using OpenQA.Selenium;

namespace Framework.PageOjects.Pages
{
    public interface IAccountCreationPage
    {
        void ClickCreateAnAccountButton(string elementName);
        void ClicksOnTheCreateAnAccountLink();
        void EnterAccountCreationDetails();
        void CreateAnAccount();
        void MainPageIdentifier();
        void MyAccountPageIdentifier();
    }

    public class AccountCreationPage : IAccountCreationPage
    {
        private readonly IDriverWait _driver;

        public AccountCreationPage(IDriverWait driver)
        {
            _driver = driver;
        }

        private IWebElement CreateAnAccountLink => _driver.FindElement(By.XPath("(//a[text()='Create an Account'])[1]"));
        private IWebElement FirstName => _driver.FindElement(By.Id("firstname"));
        private IWebElement LastName => _driver.FindElement(By.Id("lastname"));
        private IWebElement Email => _driver.FindElement(By.Id("email_address"));
        private IWebElement Password => _driver.FindElement(By.Id("password"));
        private IWebElement ConfirmPassword => _driver.FindElement(By.Id("password-confirmation"));
        private IWebElement CreateAnAccountButton => _driver.FindElement(By.XPath("//button/*[text()='Create an Account']"));
        private IWebElement PositiveLoginIdentifier => _driver.FindElement(By.XPath("//h1/*[text()='My Account']"));

        public void CreateAnAccount()
        {
            MainPageIdentifier();
            ClicksOnTheCreateAnAccountLink();
            EnterAccountCreationDetails();
            ClickCreateAnAccountButton("Create An Account Button");
            MyAccountPageIdentifier();
        }

        public void MainPageIdentifier()
        {
            CreateAnAccountLink.PageIdentifier("Main Page");
        }

        public void ClicksOnTheCreateAnAccountLink()
        {
            CreateAnAccountLink.Click("Create An Account Link");
            FirstName.PageIdentifier("Login Page");
        }

        public void EnterAccountCreationDetails()
        {
            string _firstName = Faker.Name.First();
            string _lastName = Faker.Name.Last();
            string _email = Faker.Internet.Email();
            string _password = _firstName + "@123";
            string _confirmPassword = _password;

            FirstName.TypeText("FirstName", _firstName);
            LastName.TypeText("LastName", _lastName);
            Email.TypeText("Email", _email);
            Password.TypeText("Password", _password);
            ConfirmPassword.TypeText("Confirm Password", _confirmPassword);
        }

        public void ClickCreateAnAccountButton(string elementName)
        {
            CreateAnAccountButton.Click(elementName);
        }

        public void MyAccountPageIdentifier()
        {
            PositiveLoginIdentifier.PageIdentifier("My Account Page");
        }
    }
}