using System;
using System.Collections.Generic;
using System.Text;

namespace taskmanangement.Models
{
    interface Iuser
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    interface Iloginuser
    {
        public void addloginuser();
        public bool loginvalidate(string username, string password);
    }
    class loginuser:Iuser
    {
        public string username { get; set; }
        public string password { get; set; }

        
    }
   
    }
