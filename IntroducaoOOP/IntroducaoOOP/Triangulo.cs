using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoOOP_1
{
    public class Triangulo
    {
        public int Base;
        public int Altura;

        public int Area()
        {
            return Base * Altura / 2;
        }
    }
}
