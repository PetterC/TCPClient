using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class User
    {
       
        private string userName;

        public void GetUserName()
        
        {
            Console.WriteLine();
           
            Console.WriteLine("UserName: {0}", Environment.UserName);
        }
    }
    
    }


