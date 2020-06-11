using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RevisionDiariaBT.UI
{
    public class ElementoWebLoginHomeBT
    {
        public ElementoWebLoginHomeBT(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Sección Ingresa (Login)
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li.login-wrap > a > span")]
        public IWebElement menuIngresaCuenta { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement txtpassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-login > input.btn.btn-naranjo")]
        public IWebElement btnIngresa { get; set; }
    }
}
