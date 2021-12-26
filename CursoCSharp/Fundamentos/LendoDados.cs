using System;
using System.Globalization;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine()); //Não é a forma mais recomendada de conversão

            Console.Write("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
