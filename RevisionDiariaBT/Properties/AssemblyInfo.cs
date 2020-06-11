using NUnit.Framework;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// La información general de un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos valores de atributo para modificar la información
// asociada con un ensamblado.
[assembly: AssemblyTitle("RevisionDiariaBT")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("RevisionDiariaBT")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: Parallelizable(ParallelScope.Fixtures)]
// Si establece ComVisible en false, los tipos de este ensamblado no estarán visibles 
// para los componentes COM.  Si necesita obtener acceso a un tipo de este ensamblado desde 
// COM, establezca el atributo ComVisible en true en este tipo.
[assembly: LevelOfParallelism(4)]
[assembly: ComVisible(false)]

// El siguiente GUID sirve como id. de typelib si este proyecto se expone a COM.
[assembly: Guid("a8d4981d-48c8-44a3-bf07-c1b482b794d9")]

// La información de versión de un ensamblado consta de los cuatro valores siguientes:
//
//      Versión principal
//      Versión secundaria 
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o usar los valores predeterminados de número de compilación y de revisión 
// mediante el carácter '*', como se muestra a continuación:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Configuración de Log4net
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]