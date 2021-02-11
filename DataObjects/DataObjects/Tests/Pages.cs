using DataObjects.Pages;
using NsTestFrameworkUI.Pages;

namespace DataObjects.Tests
{
    public class Pages
    {
        public static LoginPage LoginPage => PageHelpers.InitPage(new LoginPage());
        public static HomePage HomePage => PageHelpers.InitPage(new HomePage());
        public static AddressesPage AddressesPage => PageHelpers.InitPage(new AddressesPage());
    }
}
