using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using RevisionDiariaBT.UI;
using RevisionDiariaBT.Utilidades;
using NUnit.Framework;

namespace RevisionDiariaBT
{
    public class NavigateTo
    {
        public NavigateTo()
        {

        }

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ///<summary>
        /// Método para Ingresar Mundos de Beneficios
        /// </summary>
        /// 
        public static void IngresarMundos(IWebDriver Driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(Driver);
            ElementoWebMundoViajes homeViajes = new ElementoWebMundoViajes(Driver);
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            Mail mail = new Mail();
            string nombreMetodo = "Validar Ingreso Mundos";
            log.Info("Inicio de Prueba Validar Ingreso de Mundos");

            try
            {
                Thread.Sleep(3000);
                homeBT.MenuViajes.Click();
                log.Debug("Ingresa a la opción Menu Viajes desde Home Beneficios");
                Thread.Sleep(2000);
                homeBT.MenuVerTodosViajes.Click();
                log.Debug("Ingresa a la opción de Menu Viajes desde Home Beneficios");
                Thread.Sleep(5000);
                js.ExecuteScript("window.scrollBy(0,650);");
                homeViajes.ProductoViajes.Click();
                //if(homeViajes.TituloViaje.Displayed ||home)

                Driver.Navigate().GoToUrl(Config.Ambientes.urlProduccion);
                Thread.Sleep(5000);
                homeBT.MenuViajes.Click();
                Thread.Sleep(2000);
                //js.ExecuteScript("window.scrollBy(0,650);");
                Thread.Sleep(3000);
                //js.ExecuteScript("window.scrollBy(0,-650);");
                Thread.Sleep(3000);
                homeBT.MenuCategoriaChile.Click();
                Thread.Sleep(5000);
                Driver.Navigate().GoToUrl(Config.Ambientes.urlProduccion);
                Thread.Sleep(5000);
                Assert.IsTrue(true);
                mail.enviarCorreo(nombreMetodo);

            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("ERROR" + ex);
                mail.EnviarCorreoError(ex, nombreMetodo);
                Assert.True(false);
            }
        }


        public static void IngresarMundoDescuentos(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);
            ElementoWebMundoDescuento homeDesc = new ElementoWebMundoDescuento(driver);
            string cssPath = "#restaurantes > div > div.toolbar-wrapper > div";
            Mail mail = new Mail();
            string nombreMetodo = "Validar Ingreso de Mundo Descuentos";

            IWebElement cssPathelement;
            Thread.Sleep(3000);
            homeBT.menuCategoriaDescuentos.Click();
            Thread.Sleep(2000);
            homeBT.menuCategoriaRestaurantes.Click();
            try
            {
                cssPathelement = driver.FindElement(By.CssSelector(cssPath));
                if (cssPathelement.Displayed && homeDesc.Producto.Displayed)
                {
                    Console.WriteLine("Elementos desplegado");
                    mail.enviarCorreo(nombreMetodo);
                    Thread.Sleep(3000);
                    homeDesc.Producto.Click();
                    Thread.Sleep(3000);

                }
            }
            catch (NoSuchElementException ex)
            {
                mail.EnviarCorreoError(ex, nombreMetodo);
            }
            Thread.Sleep(3000);

        }
         
        public static void IngresoCarroCompra(IWebDriver Driver)
        {
            Mail mail = new Mail();

            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(Driver);
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            string nombreMetodo = "Validar CarroCompra";
            Boolean estado = false;

            try
            {
                
                homeBT.EnlaceCarroCompra.Click();
                Thread.Sleep(3000);
                Console.WriteLine("Estado :" + estado);
                try
                {
                    estado = homeBT.BtnComprarHeader.Displayed;
                    Thread.Sleep(3000);
                    homeBT.BtnComprarHeader.Click();
                    Thread.Sleep(3000);
                    homeBT.BtnEliminarProductoAbrazo.Click();
                    Thread.Sleep(3000);
                    homeBT.txtCajaBusqueda.Clear();
                    homeBT.txtCajaBusqueda.SendKeys("abrazo");
                    Thread.Sleep(3000);
                    homeBT.BtnBuscar.Click();
                    Thread.Sleep(3000);
                    homeBT.BtnPreAgregarCarro.Click();
                    Thread.Sleep(3000);
                    homeBT.btnAgregarCarro.Click();
                    Thread.Sleep(3000);
                    homeBT.btnIrPagar.Click();
                    Thread.Sleep(3000);
                    js.ExecuteScript("window.scrollBy(0,650);");
                    Thread.Sleep(3000);
                    homeBT.btnContinuar.Click();
                    js.ExecuteScript("window.scrollBy(0,-500);");
                    Thread.Sleep(3000);
                    js.ExecuteScript("window.scrollBy(0,400);");
                    Thread.Sleep(3000);
                    homeBT.RadioButtonBtnPago.Click();
                    Thread.Sleep(2000);
                    homeBT.btnContinuarPago.Click();
                    Thread.Sleep(3000);
                    homeBT.CheckBoxTerminos.Click();
                    Thread.Sleep(3000);
                    homeBT.CheckBoxCondiciones.Click();
                    Thread.Sleep(3000);
                    homeBT.btnCompraFinal.Click();
                    Thread.Sleep(10000);
                    Assert.True(true);
                    mail.enviarCorreo(nombreMetodo);
                    Driver.Quit();
                }
                catch (NoSuchElementException e)
                {
                    homeBT.txtCajaBusqueda.SendKeys("abrazo");
                    Thread.Sleep(3000);
                    homeBT.BtnBuscar.Click();
                    Thread.Sleep(3000);
                    homeBT.BtnPreAgregarCarro.Click();
                    Thread.Sleep(3000);
                    homeBT.btnAgregarCarro.Click();
                    Thread.Sleep(3000);
                    homeBT.btnIrPagar.Click();
                    Thread.Sleep(3000);
                    js.ExecuteScript("window.scrollBy(0,650);");
                    Thread.Sleep(3000);
                    homeBT.btnContinuar.Click();
                    js.ExecuteScript("window.scrollBy(0,-500);");
                    Thread.Sleep(3000);
                    js.ExecuteScript("window.scrollBy(0,400);");
                    Thread.Sleep(3000);
                    homeBT.RadioButtonBtnPago.Click();
                    Thread.Sleep(2000);
                    homeBT.btnContinuarPago.Click();
                    Thread.Sleep(3000);
                    homeBT.CheckBoxTerminos.Click();
                    Thread.Sleep(3000);
                    homeBT.CheckBoxCondiciones.Click();
                    Thread.Sleep(3000);
                    homeBT.btnCompraFinal.Click();
                    Thread.Sleep(10000);
                    Assert.True(true);
                    mail.enviarCorreo(nombreMetodo);
                    Driver.Quit();
                }
                
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("error "+ex);
                mail.EnviarCorreoError(ex, nombreMetodo);
                Assert.True(false);
                Driver.Quit();
            }
        }
        ///<summary>
        /// Metodo para Pulsar Radio Button de Terminos y Condiciones
        /// </summary>
        /// 
        public void AceptarTerminosCondiciones(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(5000);
            homeBT.CheckBoxTerminos.Click();
            Thread.Sleep(5000);
            homeBT.CheckBoxCondiciones.Click();
            Thread.Sleep(5000);
            homeBT.btnCompraFinal.Click();
        }

        ///<summary>
        /// Botones Next y Prev Carrusel Home BT
        /// </summary>

        public void BtnNextPrevCarruselHomeBT(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.btnSiguienteCarrusel.Click();
            Thread.Sleep(2000);
            homeBT.btnAnteriorCarrusel.Click();
            Thread.Sleep(2000);

        }

        ///<summary>
        /// Validar botones o Carrusel Home BT
        /// </summary>
        public void BtnSliderOCarruselHomeBT(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(1000);
            homeBT.btnCircularCarruselDos.Click();
            Thread.Sleep(1500);
            homeBT.btnCircularCarruselDos.Click();
            Thread.Sleep(1000);
            homeBT.btnCircularCarruselDos.Click();
            Thread.Sleep(1000);
            homeBT.btnCircularCarruselDos.Click();
            Thread.Sleep(1000);
            homeBT.btnCircularCarruselDos.Click();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Ingreso de Link de Sliders
        /// </summary>
        /// 

        public void GetPrimeraImagenCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.PrimerImagenCarrusel.Click();
        }

        public void GetSegundaImagenCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.SegundaImagenCarrusel.Click();
        }

        public void GetTerceraImagenCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.TerceraImagenCarrusel.Click();
        }

        public void GetCuartaImagenCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.CuartaImagenCarrusel.Click();
        }

        /// <summary>
        /// Método Pulsar Botones Carrusel
        /// </summary>

        public void getBtnNextCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnSiguienteCarrusel.Click();
        }

        public void getBtnPrevCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnSiguienteCarrusel.Click();
        }

        /// <summary>
        /// Ingreso de Enlace de Mundos BT
        /// </summary>

        public void IngresarEnlaceMundoViajes(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.LinkMundoViajes.Click();
            Thread.Sleep(2000);

        }

        public void IngresarEnlaceMundoTienda(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.LinkMundoTienda.Click();
            Thread.Sleep(2000);

        }

        public void IngresarEnlaceMundoDescuentos(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.LinkMundoDescuentos.Click();
            Thread.Sleep(2000);

        }

        ///<summary>
        /// Validar Carrusel BT
        /// </summary>

        public void BtnNextCarrusel(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(300);
            homeBT.btnSiguienteCarrusel.Click();
            Thread.Sleep(300);
            homeBT.btnSiguienteCarrusel.Click();
            Thread.Sleep(300);
            homeBT.btnSiguienteCarrusel.Click();
            Thread.Sleep(300);
            homeBT.btnSiguienteCarrusel.Click();
            Thread.Sleep(300);

        }

        ///<summary>
        /// Método Agregar Favoritos
        /// </summary>
        public void IngresarFavoritos(string correo, string pass, IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);
            ElementoWebLoginHomeBT LoginBT = new ElementoWebLoginHomeBT(driver);

            Thread.Sleep(2000);
            Actions.LoginUsuarioBT(Config.Credentials.Valid.email, Config.Credentials.Valid.password, driver);
            Thread.Sleep(2000);
            homeBT.ImagenBT.Click();
            Thread.Sleep(2000);

        }

        ///<summary>
        /// Utilizar el botón Agregar Carro
        /// </summary>

        public void IngresarBotónAgregarCarroProducto(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.btnAgregarCarritoCompra.Click();
            Thread.Sleep(2000);
            homeBT.btnIrPagar.Click();

            /*System.Threading.Thread.Sleep(2000);

            txtRutCliente.SendKeys("19887407-8");

            System.Threading.Thread.Sleep(2000);

            txtNombreCliente.SendKeys("Alex Eduardo");

            System.Threading.Thread.Sleep(2000);

            txtApellidosCliente.SendKeys("Moreno Gamboa");

            System.Threading.Thread.Sleep(2000);

            txtEmailCliente.SendKeys("amoreno@ingesmart.cl");

            System.Threading.Thread.Sleep(2000);

            txtCelularCliente.SendKeys("976526574");

            System.Threading.Thread.Sleep(2000);*/

        }

        ///<summary>
        /// Completar Sección Dirección
        /// </summary>

        public void completarDirección(string lugar, string direccion, string Region, string Comuna, IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            SelectElement selectValueRegion = new SelectElement(homeBT.comboRegionDespacho);

            SelectElement selectValueComuna = new SelectElement(homeBT.comboComunaDespacho);

            homeBT.txtAliasDireccionCliente.SendKeys(lugar);
            Thread.Sleep(2000);
            homeBT.txtDireccion.SendKeys(direccion);
            Thread.Sleep(2000);
            selectValueRegion.SelectByText(Region);
            Thread.Sleep(2000);
            selectValueComuna.SelectByText(Comuna);
            Thread.Sleep(2000);
        }

        ///<summary>
        /// Pulsar botón Continuar
        /// </summary>
        public void IngresarBtnContinuar(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnContinuar.Click();
        }

        ///<summary>
        /// Utilizar botón Ingresar Viaje X
        /// </summary>

        public void IngresarViajeX(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.ViajeX.Click();
        }

        /// <summary>
        /// Utilizar botón Cotizar
        /// </summary>
        /// 
        public void IngresoBotonCotizar(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.btnCotizarViaje.Click();
        }

        /// <summary>
        /// Botones Favoritos
        /// </summary>

        public void FavoritosViajes(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnFavoritosViajes.Click();
        }

        public void FavoritosTienda(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnFavoritosTienda.Click();
        }

        public void FavoritosDescuentos(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.btnFavoritosDescuentos.Click();
        }

        public void IngresaImagenBT(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            homeBT.ImagenBT.Click();
        }

        ///<sumary>
        /// Metodo Ir a Viajes
        /// </sumary>
        /// 

        public void IraViajes(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.menuViajes.Click();
            Thread.Sleep(2000);
            homeBT.opcionMenuIrViajes.Click();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Método Ir a Tienda
        /// </summary>
        public void IraTienda(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(2000);
            homeBT.menuTienda.Click();
            Thread.Sleep(2000);
            homeBT.menuVerTodoTienda.Click();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Método Ir a Descuento
        /// </summary>
        /// 

        public void IraDescuento(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(6000);
            homeBT.menuDescuento.Click();
            Thread.Sleep(6000);
            homeBT.opcionMenuIrDescuento.Click();
            Thread.Sleep(6000);
        }

        ///<summary>
        /// Método Pulsar Btn de Pago
        /// </summary>
        /// 
        public void IrBtnPago(IWebDriver driver)
        {
            ElementoWebHomeBT homeBT = new ElementoWebHomeBT(driver);

            Thread.Sleep(3000);
            homeBT.RadioButtonBtnPago.Click();
            Thread.Sleep(3000);
            homeBT.btnContinuarPago.Click();

        }
    }
}
