using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MainClass
{
    class FileHandling
    {
        public string WriteFile(int n)
        {
            int regno;
            string course;
            string title;
            FileStream obj = new FileStream(@"C:\Training\C# project\Training Day 2\Task\MainClass\MainClass\details.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(obj);

            sw.WriteLine("Course details");
            sw.WriteLine("***************");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter regno : ");
                regno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter course : ");
                course = Console.ReadLine();

                Console.Write("Enter course title : ");
                title = Console.ReadLine();
                
                sw.WriteLine("Regno : " + regno);
                sw.WriteLine("course : " + course);
                sw.WriteLine("title : " + title);
                sw.WriteLine();
            }
            sw.Close();
            obj.Close();

            return "Created";
        }
    }
}
