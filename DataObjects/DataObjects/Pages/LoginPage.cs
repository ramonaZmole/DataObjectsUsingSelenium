using DataObjects.Helpers.Models;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace DataObjects.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _emailInput = By.Id("session_email");
        private readonly By _passwordInput = By.Id("session_password");
        private readonly By _signInButton = By.CssSelector(".btn.btn-primary");

        private readonly By _errorMessage = By.CssSelector(".alert.alert-notice");

        #endregion

        public void Login(UserEntity user)
        {
            _emailInput.ActionSendKeys(user.Email);
            _passwordInput.ActionSendKeys(user.Password);
            _signInButton.ActionClick();
        }

        public void Login(string user, string password)
        {
            _emailInput.ActionSendKeys(user);
            _passwordInput.ActionSendKeys(password);
            _signInButton.ActionClick();
        }

        public string GetErrorMessage() => _errorMessage.GetText();
    }
}
