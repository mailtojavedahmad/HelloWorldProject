using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
   public class Program
    {
        static void Main(string[] args)
        {
            PrintMethod("Javed");
            Console.ReadLine();
        }

        public static void PrintMethod(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        
        public static int DivideMethod(int num, int den)
        {
            return num / den;
        }
    }
}
