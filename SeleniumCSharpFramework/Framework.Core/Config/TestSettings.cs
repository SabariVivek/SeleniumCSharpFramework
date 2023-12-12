using Framework.Core.Driver;

namespace Framework.Core.Config
{
    public class TestSettings
    {
        public BrowserType BrowserType { get; set; }
        public Uri? ApplicationUrl { get; set; }
        public float? TimeoutInterval { get; set; }
    }
}