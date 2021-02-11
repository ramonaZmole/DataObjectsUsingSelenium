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

        public string GetLoggedInUserEmail() => _loggedInUserEmail.GetText();

        public void GoToMenu(string menu)
        {
            _menuList.GetElements().First(x => x.Text.Equals(menu)).Click();
        }
    }
}
