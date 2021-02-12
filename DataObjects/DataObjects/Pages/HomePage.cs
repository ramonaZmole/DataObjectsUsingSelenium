using System.Linq;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace DataObjects.Pages
{
    public class HomePage
    {
        #region Selectors

        private readonly By _loggedInUserEmail = By.CssSelector(".navbar-text");
        private readonly By _menuList = By.CssSelector(".navbar-nav.mr-auto a");

        #endregion

        public bool IsUserLoggedIn(string email) => _loggedInUserEmail.GetText() == email;

        public void GoToMenu(string menu)
        {
            _menuList.GetElements().First(x => x.Text.Equals(menu)).Click();
        }
    }
}
