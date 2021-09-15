using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Mobile
    {
        public void MobileTypes()
        {
            //Types of mobiles OS
            
            Console.WriteLine("Types of Mobile : ");
            Console.WriteLine("Android ");
            Console.WriteLine("IOS ");
            Console.WriteLine("Windows ");
        }
        public void Model(string inp)
        {
            if(inp == "Android")
                Console.WriteLine("POCO  ");
            else if(inp == "IOS")
                 Console.WriteLine("Iphone ");
            else if(inp == "Windows")
                Console.WriteLine("Nokia ");
        }
    }
}
