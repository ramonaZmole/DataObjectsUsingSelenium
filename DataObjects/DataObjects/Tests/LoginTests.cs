using DataObjects.Helpers;
using DataObjects.Helpers.Api;
using DataObjects.Helpers.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataObjects.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        private readonly UserEntity _user = new UserEntity();
        private const string ErrorMessage = "Bad email or password.";

        [TestInitialize]
        public override void Before()
        {
            base.Before();
            var client = NsTestFrameworkApi.RestSharp.RequestHelper.GetRestClient(Constants.AddressBookUrl);
            client.CreateRequest(ApiResource.User, _user);
        }

        [TestMethod]
        public void UserCanLoginTest()
        {
            Pages.LoginPage.Login(_user);
            Pages.HomePage.GetLoggedInUserEmail().Should().Be(_user.Email);
        }

        [TestMethod]
        public void CheckErrorMessageWheUserDoesNotExistTest()
        {
            var user = new UserEntity();
            Pages.LoginPage.Login(user);

            Pages.LoginPage.GetErrorMessage().Should().Be(ErrorMessage);
        }

        [TestMethod]
        public void CheckErrorMessageWhenPasswordIsEmptyTest()
        {
            var user = new UserEntity { Password = "" };

            Pages.LoginPage.Login(user);

            Pages.LoginPage.GetErrorMessage().Should().Be(ErrorMessage);
        }

        [TestMethod]
        public void CheckErrorMessageWhenEmailIsEmptyTest()
        {
            var user = new UserEntity { Email = "" };

            Pages.LoginPage.Login(user);

            Pages.LoginPage.GetErrorMessage().Should().Be(ErrorMessage);
        }
    }
}
