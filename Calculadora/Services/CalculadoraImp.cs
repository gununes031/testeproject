using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private  List<string>? hist;
        private string data;

        public CalculadoraImp(string data)
        {
            hist = new List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            hist.Insert(0, "res:" + res + " - data: " + data);
            return res;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0 ;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            hist.Insert(0, "res:" + res + " - data: " + data);
            return res;
        }

        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;
            hist.Insert(0, "res:" + res + " - data: " + data);
            return res;
        }

        public int Subitrair(int num1, int num2)
        {
            int res = num1 - num2;
            hist.Insert(0, "res:" + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
            
            hist.RemoveRange(3, hist.Count - 3);
            return hist;
        }
    }
}