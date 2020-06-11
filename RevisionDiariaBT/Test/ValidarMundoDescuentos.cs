using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT.Scenario
{
    [Parallelizable(ParallelScope.None)]
    public class ValidarMundoDescuentos
    {
        public IWebDriver Driver { get; set; }

        public ValidarMundoDescuentos()
        {

        }

        /*[OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializerDriver();
        }

        [TestCase]
        /*public void ValidarCategoriaRestaurante()
        {
            NavigateTo.IngresarMundoDescuentos(Driver);
        }*/

        /*[OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }*/
    }
}
