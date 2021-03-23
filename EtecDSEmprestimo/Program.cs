using System;

using System.Globalization;

namespace EtecDSEmprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

            /**
             * A prefeitura de Jaú abriu uma linha de crédito para os funcionários estatutários. 
             * O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. Faça um 
             * programa que permita entrar com o salário bruto e o valor da prestação, e informar 
             * se o empréstimo pode ou não ser concedido.
             */
            double prestacao, salario_bruto;

            Console.WriteLine("Digite seu Salário Bruto:");
            salario_bruto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da Prestação:");
            prestacao = Convert.ToDouble(Console.ReadLine());

            double trinta_porcento_salario = salario_bruto * 0.3;

            Console.Clear();

            Console.WriteLine(
                "Prestação máxima para {0} é de {1}. Sua prestação está em: {2}", 
                salario_bruto.ToString("C", nfi), 
                trinta_porcento_salario.ToString("C", nfi),
                prestacao.ToString("C", nfi)
            );


            if(prestacao > trinta_porcento_salario)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Empréstimo NEGADO :( ");

            } else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Empréstimo APROVADO :) ");
            }


            Console.ReadKey();
        }
    }
}
