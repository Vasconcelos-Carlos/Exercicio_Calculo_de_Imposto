using System;
using System.Collections.Generic;
using Calculo_de_Imposto.Entities;

namespace Calculo_de_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> Lista_Contribuintes = new List<Contribuinte>();
            
            Console.Write("QUANTOS CONTRIBUINTE SERÃO CADASTRADOS: ");
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++)
            {
                Console.Write("Pessoa Fiscia ou Juridica ( F / J ): ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");               
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());
                if(tipo == 'J'|| tipo == 'j')
                {
                    Console.Write("Numero de Funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    Lista_Contribuintes.Add(new PessoaJuridica(nome, renda, funcionarios));

                }
                else if (tipo == 'f'||tipo == 'F')
                {
                    Console.Write("Gastos com Saude: ");
                    double gastos = double.Parse(Console.ReadLine());
                    Lista_Contribuintes.Add(new PessoaFisica(nome, renda, gastos));

                }

            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("CONTRIBUINTES:");
            foreach (Contribuinte contribuint in Lista_Contribuintes)
            {
                Console.WriteLine($"{contribuint.Nome}:  R$ {contribuint.Taxa().ToString("F2")}");
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            double total = 0;
            foreach(Contribuinte contribuint in Lista_Contribuintes)
            {
                total = total + contribuint.Taxa();
                Console.Write($"Total das taxas {total}");
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
