using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    class MobileNetwork
    {
        public void ReadFile()
        {
            FileStream obj = new FileStream(@"C:\Training\Task\Task\Network.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(obj);
            Console.WriteLine("Mobile Network Performance");
            Console.WriteLine("*************************");
            Console.WriteLine("Source\t   Destination\t  Date\t      Call-Status");

            
            while (sr.Peek() > 0)
            {
                
                    string line = sr.ReadLine();
                    if (line.Contains(":"))
                    {
                        string[] details = line.Split(':');
                        Console.Write(details[1] + "    ");
                    }
                    else
                        Console.WriteLine();
                
            }
             

        }
    }
}
