using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculo
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        
        public int Somar(int n1, int n2)
        {
            int resultado = n1 + n2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Subtrair(int n1, int n2)
        {
            int resultado = n1 - n2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
            int resultado = n1 * n2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int Dividir(int n1, int n2)
        {
            int resultado = n1 / n2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> Historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}