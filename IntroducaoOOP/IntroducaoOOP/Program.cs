using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IntroducaoOOP_1;

namespace IntroducaoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Thread.Sleep(50);

            Triangulo t = new Triangulo();
            t.Altura = 5;
            t.Base = 5;
            int area = t.Area();

            Triangulo t2 = new Triangulo();
            t2.Base = 10;
            t2.Altura = 10;
            int areaT2 = t2.Area();

        }
    }

   
}
