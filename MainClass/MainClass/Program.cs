using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,regno;
            

            Console.WriteLine("Course details : ");
            Console.Write("Enter number of courses : ");

            n = Convert.ToInt32(Console.ReadLine());
            FileHandling obj = new FileHandling();
            

                obj.WriteFile(n);
            Console.Read();



        }
    }
}
