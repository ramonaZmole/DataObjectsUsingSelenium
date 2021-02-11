using DataObjects.Helpers.Models;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace DataObjects.Pages
{
    public class AddressesPage
    {
        #region Selectors

        private readonly By _newAddressLink = By.CssSelector(".row.justify-content-center");

        #endregion

        public void AddNewAddress()
        {
            _newAddressLink.ActionClick();
        }

        public void InsertAddressDetails(AddressEntity address)
        {

        }
    }
}
