using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

using taskmanangement.Models;
using taskmanangement.Utilityfunctions;
using static System.Net.Mime.MediaTypeNames;

namespace taskmanangement
{

    class Program
    {
        static void Main(string[] args)
        {
            Loginuserfuns lf = new Loginuserfuns();
            Taskfuns tf = new Taskfuns();
            Commentsfuns cf = new Commentsfuns();
            lf.addloginuser();
            
           Console.WriteLine("Login Page");
            Console.WriteLine("Enter the user name:");
           String Username = Console.ReadLine();
             Console.WriteLine("Enter the password:");
             String Password = Console.ReadLine();
            

           if( !(lf.loginvalidate(Username, Password)))
            {
                Environment.Exit(0);
            }
           

            bool flag = true;
            
            
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add a Task\n2.Show tasks assigned to me\n3.WriteComments\n4.Logout");
                Console.WriteLine("Enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            tf.addtask(Username);
                            break;
                               
                        }
                    case 2:
                        {

                            tf.showtask(Username);
                                break;
                            
                        }
                    case 3:
                        {
                            cf.Addcomment(Username);
                            break;
                        }
                    case 4:
                        {
                            Username = " ";
                            Console.WriteLine("Successfully Logout!!");
                            break;
                        }

                }
               
                Console.WriteLine("Do You want to continue? yes/no");
                String ans = Console.ReadLine();
                if (ans == "yes" || ans == "y" || ans == "Yes")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            


            

        }
    }
}
