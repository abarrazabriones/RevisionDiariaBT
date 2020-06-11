using OpenQA.Selenium;
using NUnit.Framework;
using RevisionDiariaBT;
using RevisionDiariaBT.Utilidades;


namespace RevisionDiariaBT.Scenario
{
    
    public class ValidarHomeBT
    {
        public IWebDriver Driver { get; set; }

        public ValidarHomeBT()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
            
        {
            Driver = Actions.InitializerDriver();
            
        }

        //[TestCase]
        public void ValidarIngresoMundos()
        {
            NavigateTo.IngresarMundoDescuentos(Driver);

        }


        [TestCase]
        public void ValidarCarroCompra()
        {
            Actions.LoginUsuarioBT(Config.Credentials.Valid.email, Config.Credentials.Valid.password, Driver);
            NavigateTo.IngresoCarroCompra(Driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}


