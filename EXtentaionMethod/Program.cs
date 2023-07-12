using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXtentaionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c  =new Calculation();
           
            c.Multiply(2, 3);
            int res=c.Square(2);
            Console.WriteLine(res);
        }
    }
}
