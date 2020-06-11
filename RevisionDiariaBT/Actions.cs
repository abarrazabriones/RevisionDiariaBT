using RevisionDiariaBT.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using RevisionDiariaBT.Utilidades;
using NUnit.Framework;

namespace RevisionDiariaBT
{
    public class Actions
    {
        public static IWebDriver InitializerDriver()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(Config.Ambientes.urlProduccion);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }

        public static void LoginUsuarioBT(string correo, string password, IWebDriver driver)
        {
            ElementoWebLoginHomeBT LoginCasos = new ElementoWebLoginHomeBT(driver);
            Mail mail = new Mail();
            string nombreMetodo = "Login UsuarioBT";
            
            try
            {
                LoginCasos.menuIngresaCuenta.Click();
                //LoginCasos.txtEmail.Clear();
                LoginCasos.txtEmail.SendKeys(correo);
                //LoginCasos.txtpassword.Clear();
                LoginCasos.txtpassword.SendKeys(password);
                LoginCasos.btnIngresa.Click();
                Assert.True(true);

            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error en login de Usuario " + ex);
                mail.EnviarCorreoError(ex, nombreMetodo);
                Assert.True(false);
            }
        }
    }
}
