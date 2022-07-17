
using LoginException.Login;
using System;

namespace LoginException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoginAuther(Authentification.Mail, Authentification.Password) ;
            
        }


        static void LoginAuther(string mail, string password)
        {
            try
            {
                if (mail != Authentification.Mail || password != Authentification.Password)
                {
                    throw new Authentification("Mail ve ya Password sehvdir");
                }
                Console.WriteLine("Giris olundu");
            }
            catch (Exception message)
            {

                Console.WriteLine(message.Message); ;
            }
        }

    }
}
