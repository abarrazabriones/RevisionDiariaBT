using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoDescuento
    {
        public ElementoWebMundoDescuento(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Producto Mundo Descuento
        /// </summary>
        /// 

        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement ProductoDescuento { get; set; }


        [FindsBy(How = How.LinkText, Using = "Restaurant Panda Junior")]
        public IWebElement Producto { get; set; }

        /*[FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement ProductoDescuento { get; set; }


        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement ProductoDescuento { get; set; }*/





        /// <summary>
        /// Imagenes del Carrusel
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[2]/a/img")]
        public IWebElement ImagenCarruselDescuento1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[3]/a/img")]
        public IWebElement ImagenCarruselDescuento2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[4]/a/img")]
        public IWebElement ImagenCarruselDescuento3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[5]/a/img")]
        public IWebElement ImagenCarruselDescuento4 { get; set; }

        /// <summary>
        /// Botónes Carrusel
        /// </summary>
        /// 

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[1]/a")]
        public IWebElement BtnCarruselDescuentos1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[2]/a")]
        public IWebElement BtnCarruselDescuento2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[3]/a")]
        public IWebElement BtnCarruselDescuento3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[4]/a")]
        public IWebElement BtnCarruselDescuento4 { get; set; }

        /// <summary>
        /// Descuentos Destacados del Mes
        /// </summary>
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[2]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[3]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[5]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado4 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[6]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado5 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[7]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado6 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[8]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado7 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[9]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado8 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[10]/div/div[2]/h3/a")]
        public IWebElement DescuentoDestacado9 { get; set; }

        ///<summary>
        /// Categorias de descuentos
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "#dest_desc > div.mat-cat-img > a:nth-child(1) > img")]
        public IWebElement CategoriaDescuentoRestaurantes { get; set; }

        [FindsBy(How = How.LinkText, Using = "Bienestar")]
        public IWebElement CategoriaDescuentoBienestar { get; set; }

        [FindsBy(How = How.LinkText, Using = "Entretención")]
        public IWebElement CategoriaDescuentoEntretención { get; set; }

        [FindsBy(How = How.LinkText, Using = "Servicios")]
        public IWebElement CategoriaDescuentoServicios { get; set; }

        [FindsBy(How = How.LinkText, Using = "Educación")]
        public IWebElement CategoriaDescuentoEducación { get; set; }

        [FindsBy(How = How.LinkText, Using = "Compras")]
        public IWebElement CategoriaDescuentoCompras { get; set; }



        /// <summary>
        /// Métodos para ingresar imagenes del carrusel
        /// </summary>

        public void IngresarImagenDescuento1()
        {
            ImagenCarruselDescuento1.Click();
        }

        public void IngresarImagenDescuento2()
        {
            ImagenCarruselDescuento2.Click();
        }

        public void IngresarImagenDescuento3()
        {
            ImagenCarruselDescuento3.Click();
        }

        public void IngresarImagenDescuento4()
        {
            ImagenCarruselDescuento4.Click();
        }

        /// <summary>
        /// Métodos para ingresar botónes circulares carrusel
        /// </summary>

        public void IngresarBtnCarrusel1()
        {
            BtnCarruselDescuentos1.Click();
        }

        public void IngresarBtnCarrusel2()
        {
            BtnCarruselDescuento2.Click();
        }

        public void IngresarBtnCarrusel3()
        {
            BtnCarruselDescuento3.Click();
        }

        public void IngresarBtnCarrusel4()
        {
            BtnCarruselDescuento4.Click();
        }

        ///<summary>
        /// Métodos para ingresar Categorias Mundo Descuento
        /// </summary>
        /// 

        public void IngresarCategoriaRestaurantes()
        {
            CategoriaDescuentoRestaurantes.Click();
        }

        public void IngresarCategoriaBienestar()
        {
            CategoriaDescuentoBienestar.Click();
        }

        public void IngresarCategoriaEntretencion()
        {
            CategoriaDescuentoEntretención.Click();
        }

        public void IngresarCategoriaServicios()
        {
            CategoriaDescuentoServicios.Click();
        }

        public void IngresarCategoriaEducacion()
        {
            CategoriaDescuentoEducación.Click();
        }

        public void IngresarCategoriaCompras()
        {
            CategoriaDescuentoCompras.Click();
        }

        ///<summary>
        /// Métodos para ingresar a los descuentos destacados del mes
        /// </summary>

        public void IngresarDescuentoDestacado1()
        {
            DescuentoDestacado1.Click();
        }

        public void IngresarDescuentoDestacado2()
        {
            DescuentoDestacado2.Click();
        }

        public void IngresarDescuentoDestacado3()
        {
            DescuentoDestacado3.Click();
        }

        public void IngresarDescuentoDestacado4()
        {
            DescuentoDestacado4.Click();
        }

        public void IngresarDescuentoDestacado5()
        {
            DescuentoDestacado5.Click();
        }

        public void IngresarDescuentoDestacado6()
        {
            DescuentoDestacado6.Click();
        }

        public void IngresarDescuentoDestacado7()
        {
            DescuentoDestacado7.Click();
        }

        public void IngresarDescuentoDestacado8()
        {
            DescuentoDestacado8.Click();
        }

        public void IngresarDescuentoDestacado9()
        {
            DescuentoDestacado9.Click();
        }
    }
}
