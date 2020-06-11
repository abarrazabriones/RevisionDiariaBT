using OpenQA.Selenium;
using System;
using System.Net.Mail;


namespace RevisionDiariaBT.Utilidades
{
    public class Mail
    {
        public Mail()
        {

        }

        public static string correoDestino ="amoreno@ingesmart.cl";
        public static string ruta = @"\\192.168.1.15\ddi\16. Resultados QA\Revision Diaria\Beneficios Tarjetas\Producción";


        public void enviarCorreo(string nombreMetodo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.ingesmart.cl");

                mail.From = new MailAddress("amoreno@ingesmart.cl", "Alex Moreno Gamboa");
                //mail.To.Add("amoreno@ingesmart.cl");
                mail.To.Add("ccarrasco@ingesmart.cl");
                mail.CC.Add("psandoval@ingesmart.cl");
                mail.CC.Add("mdiaz@ingesmart.cl");
                mail.CC.Add("dgperez@ingesmart.cl");
                mail.CC.Add("sriquelme@ingesmart.cl");
                mail.CC.Add("amoreno@ingesmart.cl");
                mail.Subject = "Prueba " + nombreMetodo + "_OK";
                mail.Body = "Estimados,\n         " +
                    "\n Informo que la prueba " + nombreMetodo + " se efectuo con exito el cual no se presentaron defectos.";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("amoreno@ingesmart.cl", "Aemg.7375");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Enviado ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.ToString());
            }
                
        }

        public void EnviarCorreoError(NoSuchElementException no, string nombreMetodo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.ingesmart.cl");

                mail.From = new MailAddress("amoreno@ingesmart.cl", "Alex Moreno Gamboa");
                //mail.To.Add("amoreno@ingesmart.cl");
                mail.To.Add("ccarrasco@ingesmart.cl");
                mail.CC.Add("psandoval@ingesmart.cl");
                mail.CC.Add("mdiaz@ingesmart.cl");
                mail.CC.Add("dgperez@ingesmart.cl");
                mail.CC.Add("sriquelme@ingesmart.cl");
                mail.CC.Add("amoreno@ingesmart.cl");
                mail.Subject = "Prueba "+ nombreMetodo +"_ERROR";
                mail.Body = "Estimados,\n         " +
                    "\n Se detecto un error al probar la prueba "+nombreMetodo+" se realizara la revisión de modificaciones en los elementos, se agrega el mensaje de error: " + "\n" + no.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("amoreno@ingesmart.cl", "Aemg.7375");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Enviado Error" + no);

            }
            catch(Exception exc)
            {
                Console.WriteLine("Error Encontrado" + exc.ToString());
            }
        }
    }
}
