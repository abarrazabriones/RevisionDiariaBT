using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT.UI
{
    public class ElementoWebHomeBT
    {
        public ElementoWebHomeBT(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Variables Mundo Viajes
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.viajes_menu > a > span")]
        public IWebElement MenuViajes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > h2 > a")]
        public IWebElement MenuVerTodosViajes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(2) > ul > a")]
        public IWebElement MenuCategoriaChile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(3) > ul > a")]
        public IWebElement MenuCategoriaSudamerica { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(4) > ul > a")]
        public IWebElement MenuCategoriaMexicoCaribe { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(5) > ul > a")]
        public IWebElement MenuCategoriaNorteamérica { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(6) > ul > a")]
        public IWebElement MenuCategoriaEuropaLejanos { get; set; }


        /// <summary>
        /// Variables Menú Mundo Tienda
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.tiendas_menu > a > span")]
        public IWebElement menuTienda { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tiendas > div > h2 > a")]
        public IWebElement menuVerTodoTienda { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tiendas > div > div:nth-child(2) > div:nth-child(1) > h3 > a")]
        public IWebElement menuCategoriaTecnologia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > div > div > li:nth-child(6) > ul > a")]
        public IWebElement menuCategoriaHogar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tiendas > div > div:nth-child(2) > div:nth-child(3) > h3 > a")]
        public IWebElement menuCategoriaBelleza { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tiendas > div > div:nth-child(2) > div:nth-child(4) > h3 > a")]
        public IWebElement menuCategoriaDeporte { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tiendas > div > div:nth-child(2) > div:nth-child(5) > h3 > a")]
        public IWebElement menuCategoriaInfantil { get; set; }

        [FindsBy(How = How.CssSelector, Using = "# tiendas > div > div:nth-child(2) > div:nth-child(4) > h3 > a")]
        public IWebElement menuCategoriaEspeciales { get; set; }




        ///<summary>
        /// Categorías Descuentos
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.desc_menu > a > span")]
        public IWebElement menuCategoriaDescuentos { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > h2 > a")]
        public IWebElement menuVerTodoDescuentos { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(2) > div:nth-child(1) > h3 > a")]
        public IWebElement menuCategoriaRestaurantes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(2) > div:nth-child(2) > h3 > a")]
        public IWebElement menuCategoriaBienestar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(2) > div:nth-child(5) > h3 > a")]
        public IWebElement menuCategoriaEducacion { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(2) > div:nth-child(3) > h3 > a")]
        public IWebElement menuCategoriaEntretencion { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(2) > div:nth-child(4) > h3 > a")]
        public IWebElement menuCategoriaServicios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(3) > div:nth-child(1) > h3 > a")]
        public IWebElement menuCategoriaCompras { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#descuentos > div > div:nth-child(3) > div:nth-child(2) > h3 > a")]
        public IWebElement menuCategoriaEcoEficiencia { get; set; }

        /// <summary>
        /// Botones Anterior y Siguiente Carrusel Home Beneficios
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[2]/div[2]/a[2]")]
        public IWebElement btnSiguienteCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[2]/div[2]/a[1]")]
        public IWebElement btnAnteriorCarrusel { get; set; }

        ///<summary>
        /// Imagen Beneficios Tarjetas
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > h1 > a")]
        public IWebElement ImagenBT { get; set; }

        /// <summary>
        /// Imagenes Carrusel Home Beneficios
        /// </summary>

        [FindsBy(How = How.Id, Using = "img-slider0")]
        public IWebElement PrimerImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[3]/a/img")]
        public IWebElement SegundaImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[4]/a/img")]
        public IWebElement TerceraImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[5]/a/img")]
        public IWebElement CuartaImagenCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/div/div[1]/ul/li[6]/a/img")]
        public IWebElement QuintaImagenCarrusel { get; set; }

        ///<summary>
        ///Botones circulares Carrusel Home
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[1]/a")]
        public IWebElement btnCircularCarruselUno { get; set; }

        [FindsBy(How = How.ClassName, Using = "bx-pager-link")]
        public IWebElement btnCircularCarruselDos { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[3]/a")]
        public IWebElement btnCircularCarruselTres { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[4]/a")]
        public IWebElement btnCircularCarruselCuatro { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]/div[1]/div[5]/a")]
        public IWebElement btnCircularCarruselQuinto { get; set; }

        ///<summary>
        /// Link Destacados
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[2]/a/img")]
        public IWebElement CalugaCorreosChile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[5]/a/img")]
        public IWebElement CalugaLinio { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[6]/a/img")]
        public IWebElement CalugaFrigosorno { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[6]/a/img")]
        public IWebElement CalugaSamsung { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[8]/a/img")]
        public IWebElement CalugaSalcobrand { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[9]/a/img")]
        public IWebElement CalugaCorteIngles { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[10]/a/img")]
        public IWebElement CalugaLibreriaNacional { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[11]/a/img")]
        public IWebElement CalugaDespegar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[12]/a/img")]
        public IWebElement CalugaMovistar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[12]/a/img")]
        public IWebElement CalugaReifstore { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[14]/a/img")]
        public IWebElement CalugaA3D { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/div/div/div[15]/a/img")]
        public IWebElement CalugaViajesNovajet { get; set; }

        ///<summary>
        /// Botones Calugas Home
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[2]")]
        public IWebElement btnCalugasNext { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/section/button[1]")]
        public IWebElement btnCalugaPrev { get; set; }

        ///<summary>
        /// Menú Ingreso de Mundo Viajes
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[1]")]
        public IWebElement menuViajes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > h2 > a")]
        public IWebElement opcionMenuIrViajes { get; set; }

        /// <summary>
        /// Menú Ingreso de Mundo Tienda
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[3]")]
        public IWebElement menuDescuento { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[3]/div/h2/a")]
        public IWebElement opcionMenuIrDescuento { get; set; }

        /// <summary>
        /// Links Categoría Mundos
        /// </summary>
        /// 

        [FindsBy(How = How.LinkText, Using = "Ver todos los viajes")]
        public IWebElement LinkMundoViajes { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver toda la tienda")]
        public IWebElement LinkMundoTienda { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver todos los descuentos")]
        public IWebElement LinkMundoDescuentos { get; set; }

        ///<summary>
        ///Explorar Viajes
        ///</summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[1]/div[2]/a/h4")]
        public IWebElement CategoriaChile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[2]/div[2]/a/h4")]
        public IWebElement CategoriaSudamérica { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[3]/div[2]/a/h4")]
        public IWebElement CategoriaMexicoyCaribe { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[4]/div[2]/a/h4")]
        public IWebElement CategoriaNorteamérica { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[5]/div[2]/a/h4")]
        public IWebElement CategoriaEuropayLejanos { get; set; }

        /// <summary>
        /// Header BT
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li.login-wrap > a > span")]
        public IWebElement menuIngresaCuenta { get; set; }

        /// Xpath Antiguo
        ///html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[2]/a/span")]
        public IWebElement menuInformacionAyuda { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=" + "modal - carro" + "]/span")]
        public IWebElement menuCarrodeCompra { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[4]/a/span")]
        public IWebElement menuSeguimientoLinea { get; set; }

        /// <summary>
        /// Botón Favoritos Viajes
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[1]/div[2]/div[3]/ul/ul/li/a")]
        public IWebElement btnFavoritosViajes { get; set; }

        /// <summary>
        /// Botón Favoritos Tienda
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[2]/div[2]/div[3]/ul/ul/li[1]/a")]
        public IWebElement btnFavoritosTienda { get; set; }

        /// <summary>
        /// Botón Favoritos Descuentos
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[3]/div[2]/div[3]/ul/ul/li/a")]
        public IWebElement btnFavoritosDescuentos { get; set; }


        /// <summary>
        /// Viaje X
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[4]/section/div[1]/div[3]/div[2]/h3/a")]
        public IWebElement ViajeX { get; set; }


        ///<summary>
        /// Boton Cotizar
        /// </summary>
        /// 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div/div[4]/div[2]/div[2]/div[1]/div/div/div[3]/div[2]/article/div[2]/div[1]/div[2]/div/form/input[9]")]
        public IWebElement btnCotizarViaje { get; set; }

        ///<summary>
        /// Botón de Pago RadioButton
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "#paso-pago > article > div.col-7.down-tablets-vertical > div.proceso-pago > ul:nth-child(3) > li:nth-child(1) > label")]
        public IWebElement RadioButtonBtnPago { get; set; }

        ///<summary>
        /// Botón Carro de Compra
        /// </summary>
        /// 
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main-container.col1-layout > div > div > div > div > div.bg-grey > section > div.third.tienda-bloq > div:nth-child(3) > div.pro-action > ul > ul > li.cart > a")]
        public IWebElement btnAgregarCarritoCompra { get; set; }

        ///<summary>
        /// Elementos Carro Compra
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div[2]/article/div[3]/div[1]/div[2]/div/p/button")]
        public IWebElement btnCarroTienda { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main-container.col1-layout > div.main > div > div > div.product-view > div.bg-grey.bg-dcto-ctarut > article > div.col-7.down-tablets-vertical > div.single-product-info > div.single-content.cutarut-info-prod > div > p > button > span > span")]
        public IWebElement btnAgregarCarro { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#updateCart > div.carro-botones > input")]
        public IWebElement btnIrPagar { get; set; }

        [FindsBy(How = How.Id, Using = "cli-rut")]
        public IWebElement txtRutCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-nombre")]
        public IWebElement txtNombreCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-apellido")]
        public IWebElement txtApellidosCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-email")]
        public IWebElement txtEmailCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-celular")]
        public IWebElement txtCelularCliente { get; set; }

        [FindsBy(How = How.Id, Using = "dir-nombre")]
        public IWebElement txtAliasDireccionCliente { get; set; }

        [FindsBy(How = How.Id, Using = "direccion-despacho")]
        public IWebElement txtDireccion { get; set; }

        [FindsBy(How = How.Id, Using = "region-despacho")]
        public IWebElement comboRegionDespacho { get; set; }

        [FindsBy(How = How.Id, Using = "comuna-despacho")]
        public IWebElement comboComunaDespacho { get; set; }

        [FindsBy(How = How.Id, Using = "btn-continuar-p3")]
        public IWebElement btnContinuar { get; set; }

        [FindsBy(How = How.XPath, Using = "btns-despacho")]
        public IWebElement btnDespacho { get; set; }

        ///<summary>
        /// Método Continuar Pago
        /// </summary>
        /// 
        [FindsBy(How = How.Id, Using = "btn-continuar-pago")]
        public IWebElement btnContinuarPago { get; set; }

        /// <summary>
        ///  Terminos y condiciones
        /// </summary>
        /// 
        [FindsBy(How = How.CssSelector, Using = "#paso-4 > article > div.col-7.down-tablets-vertical.confirmacion-compra > div.confir-boletas > ul:nth-child(1) > li > label.boletas-check")]
        public IWebElement CheckBoxTerminos { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#paso-4 > article > div.col-7.down-tablets-vertical.confirmacion-compra > div.confir-boletas > ul:nth-child(2) > li > label.boletas-check")]
        public IWebElement CheckBoxCondiciones { get; set; }

        ///<summary>
        /// Método Continuar Pago
        /// </summary>
        [FindsBy(How = How.Id, Using = "compra-final")]
        public IWebElement btnCompraFinal { get; set; }


        ///<summary>
        ///Método para agregar valor en caja busqueda
        ///
        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement txtCajaBusqueda { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#search_mini_form > div > button")]
        public IWebElement BtnBuscar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div > div.base.page.responsive > div.main-container.col1-layout > div.main > div > div > div.category-products > div > div.clearfix > div > div > div.pro-action > ul.pro-action-cart > button")]
        public IWebElement BtnPreAgregarCarro { get; set; }

        ///<summary>
        /// Header Beneficios
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Información y ayuda'])[1]/following::span[1]")]
        public IWebElement EnlaceCarroCompra { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[1]/div/nav/ul/li[3]/div/div/div[1]/input")]
        public IWebElement BtnComprarHeader { get; set; }

        [FindsBy(How = How.ClassName, Using = "eliminar")]
        public IWebElement BtnEliminarProductoAbrazo { get; set; }

        [FindsBy(How = How.ClassName, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li.carro-wrap.active > div > div > p")]
        public IWebElement LabelTexto { get; set; }

    }

}