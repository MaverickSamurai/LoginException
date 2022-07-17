using System;


namespace LoginException.Login
{
    public class Authentification : Exception
    {
        public static string Mail = "mirsamirba@code.edu.az";
        public static string Password = "Yambaleyy7895";
        public Authentification(string message) : base(message)
        {

        }

    }
}