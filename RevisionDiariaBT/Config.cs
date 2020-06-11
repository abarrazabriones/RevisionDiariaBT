namespace RevisionDiariaBT
{
    public static class Config
    {

        public class Ambientes
        {
            public static string urlDesarrollo = "https://desarrollobeneficiosbe.ingesmart.cl";
            public static string urlCertificacion = "https://certificacionbeneficios.ingesmart.cl/";
            public static string urlProduccion = "https://www.beneficiostarjetas.cl/";
        }

        public class Credentials
        {
            public class Valid
            {
                public static string email = "pruebaingesmart@gmail.com";
                public static string password = "123qwe";
            }
            
        }

        public class Correo
        {
            public static string servidorCorreo = "mail.ingesmart.cl";
            public static int puertoCorreo = 587;
            
            public class Credenciales
            {
                public static string cuentaCorreo = "amoreno@ingesmart.cl";
                public static string passwordCorreo = "Aemg.7375";
            }
        }

    }
}
