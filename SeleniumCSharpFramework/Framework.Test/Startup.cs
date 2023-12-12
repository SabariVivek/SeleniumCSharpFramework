using Framework.Core.Config;
using Framework.Core.Driver;
using Framework.Test.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton(ConfigReader.ReadConfig())
                .AddScoped<IDriverFixture, DriverFixture>()
                .AddScoped<IDriverWait, DriverWait>()
                .AddScoped<ILoginPage, LoginPage>()
                .AddScoped<IAccountCreationPage, AccountCreationPage>()
                .AddScoped<IMyAccountPage, MyAccountPage>();
        }
    }
}