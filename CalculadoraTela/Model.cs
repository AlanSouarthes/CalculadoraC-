using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTela
{
    class Model
    {
        public Model()
        {

        }

        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subtrair(int num1, int num2)
        {
            return num1 - num2;

        }

        public int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
