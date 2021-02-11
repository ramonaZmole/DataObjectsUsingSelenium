using Microsoft.VisualStudio.TestTools.UnitTesting;
using NsTestFrameworkUI.Helpers;

namespace DataObjects.Helpers
{
    public class BaseTest : NsTestFrameworkUI.BaseTest
    {
        [TestInitialize]
        public virtual void Before()
        {
            Browser.InitializeDriver();
            Browser.WebDriver.Navigate().GoToUrl(Constants.SignInUrl);
            //Browser.GoTo(Constants.SignInUrl);
        }
    }
}
