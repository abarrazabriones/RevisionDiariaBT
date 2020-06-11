using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDiariaBT
{
    class ElementoWebMundoViajes
    {
        public ElementoWebMundoViajes(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        /// <summary>
        /// Variables Mundo Viajes
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.viajes_menu > a > span")]
        public IWebElement MenuViajes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viajes > div > h2 > a")]
        public IWebElement MenuVerTodsViajes { get; set; }

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
        /// Producto Mundo Descuento
        /// </summary>
        /// 

        [FindsBy(How = How.LinkText, Using = "Antofagasta")]
        public IWebElement ProductoViajes { get; set; }

        ///<summary>
        /// Elementos de Producto Viaje
        /// </summary>
        /// 

        [FindsBy(How = How.LinkText, Using = "body > div.rt-bg > div > div > div.base.page.responsive > div.main-container.col1-layout > div.main > div > div > div.product-view > div.bg-grey.bg-dcto-ctarut > article > h1")]
        public IWebElement TituloViaje { get; set; }



        ///<summary>
        ///Botóne Next and Prev
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/ul/li[2]/a")]
        public IWebElement btnNetxMundoViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/ul/li[1]/a")]
        public IWebElement btnPrevMundoViajes { get; set; }

        ///<summary>
        ///Botones debajo de cada imagen carrusel Mundo Viajes
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/ol/li[1]/a")]
        public IWebElement btnUnoCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/ol/li[2]/a")]
        public IWebElement btnDosCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/ol/li[3]/a")]
        public IWebElement btnTresCarrusel { get; set; }


        ///<summary>
        /// Carrusel Viajes
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/div/ul/li[2]/a/img")]
        public IWebElement PrimeraImagenViajeCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/div/ul/li[3]/a/img")]
        public IWebElement SegundaImagenViajeCarrusel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/section/div/article/div[1]/div/ul/li[4]/a/img")]
        public IWebElement TerceraImagenViajeCarrusel { get; set; }

        ///<summary>
        /// Descubre Las Ofertas destacadas de esta semana
        /// </summary>

        [FindsBy(How = How.Id, Using = "deta-product1")]
        public IWebElement ViajeDestacadoSemana1 { get; set; }

        [FindsBy(How = How.Id, Using = "deta-product2")]
        public IWebElement ViajeDestacadoSemana2 { get; set; }

        [FindsBy(How = How.Id, Using = "deta-product3")]
        public IWebElement ViajeDestacadoSemana3 { get; set; }


        ///<summary>
        /// Viajes Destacados 
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[4]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[5]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[6]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[7]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes4 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[8]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes5 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/div[9]/div/div[2]/h3/a")]
        public IWebElement ViajeDestacadoDelMes6 { get; set; }

        ///<summary>
        ///Especial Viajes El Corte Inglés
        /// </summary>

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/section[1]/article[1]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesVerano { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/section[1]/article[2]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesEuropa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div/div[2]/section/div[1]/div[2]/section[1]/article[3]/div[2]/a/h4")]
        public IWebElement CategoriaCorteInglesVuelo { get; set; }

        //


        /// <summary>
        /// Ingreso Programas Vuelos, Hoteles y Programas
        /// </summary>

        [FindsBy(How = How.LinkText, Using = "Ver todos los Vuelos")]
        public IWebElement VerTodosLosVuelos { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver todos los Hoteles")]
        public IWebElement VerTodosLosHoteles { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ver todos los programas")]
        public IWebElement VerTodosLosProgramas { get; set; }


        /// <summary>
        /// Calugas Categorias Explorar Viajes
        /// </summary>
        /// 


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/section[2]/div[2]/article[1]/div[1]/a/img")]
        public IWebElement ViajesCategoriaChile { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main - container.col1 - layout > div > div > div > div > div > section.single.row.pad - m > div.mat - cats > article:nth - child(3) > div.mat - det - cat > a > h4")]
        public IWebElement ViajesCategoriaSudamerica { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main-container.col1-layout > div > div > div > div > div > section.single.row.pad-m > div.mat-cats > article:nth-child(4) > div.mat-det-cat > a > h4")]
        public IWebElement ViajesCategoriaMexicoyCaribe { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main-container.col1-layout > div > div > div > div > div > section.single.row.pad-m > div.mat-cats > article:nth-child(5) > div.mat-det-cat > a > h4")]
        public IWebElement ViajesCategoriaNorteamérica { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.base.page.responsive > div.main-container.col1-layout > div > div > div > div > div > section.single.row.pad-m > div.mat-cats > article.col-m-2.mat-cat.last > div.mat-det-cat > a > h4")]
        public IWebElement ViajesCategoriaEuropayLejanos { get; set; }

        ///<summary>
        /// Método Botones Next and Prev
        /// </summary>
        /// 
        public void BtnNextPrevCarruselHomeViajesBT()
        {
            System.Threading.Thread.Sleep(2000);

            btnNetxMundoViajes.Click();

            System.Threading.Thread.Sleep(2000);

            btnPrevMundoViajes.Click();

            System.Threading.Thread.Sleep(2000);

        }

        /// <summary>
        /// Método botones circulares Carrusel Mundo Viajes
        /// </summary>
        /// 
        public void BtnSliderOCarruselMundoViajes()
        {
            System.Threading.Thread.Sleep(1500);

            btnUnoCarrusel.Click();

            System.Threading.Thread.Sleep(1000);

            btnDosCarrusel.Click();

            System.Threading.Thread.Sleep(1000);

            btnTresCarrusel.Click();

            System.Threading.Thread.Sleep(1500);
        }

        ///<summary>
        /// Método Ingresar Sliders Carrusel Mundo Viajes
        /// </summary>
        /// 
        public void IngresarPrimeraImagenCarruselViajes()
        {
            PrimeraImagenViajeCarrusel.Click();            
        }

        public void IngresarSegundaImagenCarruselViajes()
        {
            SegundaImagenViajeCarrusel.Click();
        }

        public void IngresarTerceraImagenCarruselViajes()
        {
            TerceraImagenViajeCarrusel.Click();
        }

        ///<summary>
        /// Método Ingresa botones circulares sliders Carrusel Mundo Viajes
        /// </summary>
        /// 
        public void IngresarPrimerCirculo()
        {
            btnUnoCarrusel.Click();
        }

        public void IngresarSegundoCirculo()
        {
            btnDosCarrusel.Click();
        }

        public void IngresarTercerCirculo()
        {
            btnTresCarrusel.Click();
        }

        ///<summary>
        /// Método Ingresa Viajes Destacados
        /// </summary>
        /// 
        public void IngresarViajeDestacado1()
        {
            ViajeDestacadoSemana1.Click();
        }

        public void IngresarViajeDestacado2()
        {
            ViajeDestacadoSemana2.Click();
        }

        public void IngresarViajeDestacado3()
        {
            ViajeDestacadoSemana3.Click();
        }

        /// <summary>
        /// Métodos Ingresa Programa Corte Ingles
        /// </summary>
        /// 
        public void IngresaCorteInglesVerano()
        {

            CategoriaCorteInglesVerano.Click();
        }

        public void IngresaCorteInglesEuropa()
        {

            CategoriaCorteInglesEuropa.Click();
        }

        public void IngresaCorteInglesVuelo()
        {

            CategoriaCorteInglesVuelo.Click();
        }

        /// <summary>
        /// Método para ingresar links Programas Vuelos, Hoteles y Programas
        /// </summary>
        /// 

        public void IngresarProgramaVuelos()
        {
            VerTodosLosVuelos.Click();
        }

        public void IngresarProgramaHoteles()
        {
            VerTodosLosHoteles.Click();
        }

        public void IngresarProgramas()
        {
            VerTodosLosProgramas.Click();
        }

        ///<summary>
        /// Método para ingresar links Viajes Destacados
        /// </summary>

        public void IngresoViajeDestacado1()
        {
            ViajeDestacadoDelMes1.Click();
        }

        public void IngresoViajeDestacado2()
        {
            ViajeDestacadoDelMes2.Click();
        }

        public void IngresoViajeDestacado3()
        {
            ViajeDestacadoDelMes3.Click();
        }

        public void IngresoViajeDestacado4()
        {
            ViajeDestacadoDelMes4.Click();
        }

        public void IngresoViajeDestacado5()
        {
            ViajeDestacadoDelMes5.Click();
        }

        public void IngresoViajeDestacado6()
        {
            ViajeDestacadoDelMes6.Click();
        }

        /// <summary>
        /// Método para ingresar categorias Viajes
        /// </summary>
        /// 
        public void IngresarCategoriaChile()
        {
            ViajesCategoriaChile.Click();
        }

        public void IngresarCategoriaSudamerica()
        {
            ViajesCategoriaSudamerica.Click();
        }

        public void IngresarCategoriaMexicoCaribe()
        {
            ViajesCategoriaMexicoyCaribe.Click();
        }

        public void IngresarCategoriaNorteamerica()
        {
            ViajesCategoriaNorteamérica.Click();
        }

        public void IngresarCategoriaEuropaLejanos()
        {
            ViajesCategoriaEuropayLejanos.Click();
        }

        ///
    }

}
