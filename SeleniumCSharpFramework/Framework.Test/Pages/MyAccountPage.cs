namespace Framework.Test.Pages
{
    public interface IMyAccountPage
    {
        void AssertMyAccountPage();
    }

    public class MyAccountPage : IMyAccountPage
    {
        private readonly IDriverWait _driver;

        public MyAccountPage(IDriverWait driverWait)
        {
            _driver = driverWait;
        }

        private IWebElement MyAccountPageIdentifier => _driver.FindElement(By.XPath("//*[@data-ui-id='page-title-wrapper']"));

        public void AssertMyAccountPage()
        {
            Assert.Equal("My Account", MyAccountPageIdentifier.Text);
        }
    }
}