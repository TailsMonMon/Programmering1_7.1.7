using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._1._7 {
    class Program {
        static void Main(string[] args) {
            char aChar = (char)64;
            Console.WriteLine("a, Snabel a: "+aChar);

            char bChar = (char)165;
            Console.WriteLine("b, yen: "+bChar);

            char cChar = (char)247;
            Console.WriteLine("c, divide: "+cChar);

            char dChar = (char)255;
            Console.WriteLine("d, last one: "+dChar);

            Console.WriteLine("Aything beyond 255 isn't working properly.");

            Console.ReadLine();
        }
    }
}
