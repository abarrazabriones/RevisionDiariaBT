using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoTienda
    {
        public ElementoWebMundoTienda(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        /// <summary>
        /// Producto Mundo Tienda
        /// </summary>
        /// 

        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement ProductoDescuento { get; set; }


        /// <summary>
        /// Botónes circulares Carrusel Mundo Tienda
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[1]/a")]
        public IWebElement BtnCirculoTienda1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[2]/a")]
        public IWebElement BtnCirculoTienda2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/ol/li[3]/a")]
        public IWebElement BtnCirculoTienda3 { get; set; }


        ///<summary>
        /// Imagenes de Carrusel Mundo Tienda
        /// </summary>
        /// 
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[2]/a/img")]
        public IWebElement ImagenCarrusel1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[3]/a/img")]
        public IWebElement ImagenCarrusel2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[1]/div/article/div[1]/div/ul/li[4]/a/img")]
        public IWebElement ImagenCarrusel3 { get; set; }

        /// <summary>
        /// Productos Destacados Mundo Tienda
        /// </summary>
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[2]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[3]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[4]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[5]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado4 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[6]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado5 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[7]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado6 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[8]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado7 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[9]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado8 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[1]/div[10]/div/div[2]/h3/a")]
        public IWebElement ProductoDestacado9 { get; set; }

        /// <summary>
        /// Categorias Mundo Tienda
        /// </summary>


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[3]/article[1]/div[2]/a[2]/h4")]
        public IWebElement CategoriaTiendaTecnologia { get; set; }

        [FindsBy(How = How.LinkText, Using = "Hogar")]
        public IWebElement CategoriaTiendaHogar { get; set; }

        [FindsBy(How = How.LinkText, Using = "Belleza")]
        public IWebElement CategoriaTiendaBelleza { get; set; }

        [FindsBy(How = How.LinkText, Using = "Deportes")]
        public IWebElement CategoriaTiendaDeportes { get; set; }

        [FindsBy(How = How.LinkText, Using = "Infantil")]
        public IWebElement CategoriaTiendaInfantil { get; set; }



        ///<summary>
        /// Método para botónes circulares de Carrusel Tienda
        /// </summary>
        public void IngresarPrimerBtnCircular()
        {
            BtnCirculoTienda1.Click();
        }

        public void IngresarSegundoBtnCircular()
        {
            BtnCirculoTienda2.Click();
        }

        public void IngresarTerceroBtnCircular()
        {
            BtnCirculoTienda3.Click();
        }

        /// <summary>
        ///  Método para ingresar Imagenes Carrusel Tienda
        /// </summary>
        public void IngresarPrimeraImagenCarruselTienda()
        {
            ImagenCarrusel1.Click();
        }

        public void IngresarSegundaImagenCarruselTienda()
        {
            ImagenCarrusel2.Click();
        }

        public void IngresarTerceraImagenCarruselTienda()
        {
            ImagenCarrusel3.Click();
        }

        /// <summary>
        /// Método para Ingresar Productos Destacados
        /// </summary>
        /// 

        public void IngresarProductoDestacadoTienda1()
        {
            ProductoDestacado1.Click();
        }

        public void IngresarProductoDestacadoTienda2()
        {
            ProductoDestacado2.Click();
        }

        public void IngresarProductoDestacadoTienda3()
        {
            ProductoDestacado3.Click();
        }

        public void IngresarProductoDestacadoTienda4()
        {
            ProductoDestacado4.Click();
        }

        public void IngresarProductoDestacadoTienda5()
        {
            ProductoDestacado5.Click();
        }

        public void IngresarProductoDestacadoTienda6()
        {
            ProductoDestacado6.Click();
        }

        public void IngresarProductoDestacadoTienda7()
        {
            ProductoDestacado7.Click();
        }

        public void IngresarProductoDestacadoTienda8()
        {
            ProductoDestacado8.Click();
        }

        public void IngresarProductoDestacadoTienda9()
        {
            ProductoDestacado9.Click();
        }


        /// <summary>
        /// Método para ingresar categorias Tienda
        /// </summary>
        /// 
        public void IngresarCategoriaTecnologia()
        {
            CategoriaTiendaTecnologia.Click();
        }

        public void IngresarCategoriaHogar()
        {
            CategoriaTiendaHogar.Click();
        }

        public void IngresarCategoriaBelleza()
        {
            CategoriaTiendaBelleza.Click();
        }

        public void IngresarCategoriaDeportes()
        {
            CategoriaTiendaDeportes.Click();
        }

        public void IngresarCategoriaInfantil()
        {
            CategoriaTiendaInfantil.Click();
        }
    }
}
