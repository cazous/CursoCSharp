using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("A área é: " + area);
            Console.WriteLine(area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade:" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menoValorInt = int.MinValue;
            Console.WriteLine("Menor int: " + menoValorInt);

            uint populacaoBrasileira = 207_600_000; //Utilizar o underscore pra dar mais clareza ao número
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine(menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo";
            Console.WriteLine(texto);

        }
    }
}
