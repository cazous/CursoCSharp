using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //Método de instância.
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Método de Classe.
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    internal class MetodosEstaticos //Metodos estaticos pertencem a classe, ou seja, n é necessario instancia para o seu uso dentro da classe
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2));
        }
    }
}
