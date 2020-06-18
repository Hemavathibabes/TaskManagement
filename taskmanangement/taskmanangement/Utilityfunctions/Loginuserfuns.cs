using System;
using System.Collections.Generic;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Utilityfunctions
{
    class Loginuserfuns:Iloginuser
    {
        List<loginuser> user = new List<loginuser>();
        public void addloginuser()
        {

            user.Add(new loginuser() { username = "Hema", password = "1234" });
            user.Add(new loginuser() { username = "Banu", password = "5678" });

        }
        public bool loginvalidate(string username, string password)
        {
            bool login = false;
            foreach (loginuser lu in user)
            {

                if (username == lu.username && password == lu.password)
                {
                    Console.WriteLine("Successsfull login!!");
                    Console.WriteLine("Welcome {0}", lu.username);
                }
                login = true;
            }



            if (login == false)
            {
                Console.WriteLine("Username and Password does not match");
                Console.WriteLine("Try again later!");

            }
            return login;

        }
    }
}
