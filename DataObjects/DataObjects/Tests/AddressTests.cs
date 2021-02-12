using DataObjects.Helpers;
using DataObjects.Helpers.Api;
using DataObjects.Helpers.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataObjects.Tests
{
    [TestClass]
    public class AddressTests : BaseTest
    {
        private readonly UserEntity _user = new UserEntity();

        [TestInitialize]
        public override void Before()
        {
            base.Before();
            var client = NsTestFrameworkApi.RestSharp.RequestHelper.GetRestClient(Constants.AddressBookUrl);
            client.CreateRequest(ApiResource.User, _user);
        }

        [TestMethod]
        public void AddressCanBeAddedTest()
        {
            Pages.LoginPage.Login(_user);
            Pages.HomePage.GoToMenu(MenuType.Addresses.ToString());

            Pages.AddressesPage.AddNewAddress();
        }
    }
}
