using System;

namespace VetorExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quarto = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdQuartos; i++)
            {
                int qu = 1;
                Quarto q;
                Console.WriteLine("Aluguel #" + i + ":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (numQuarto < 10 && quarto[numQuarto] == null)
                {
                    q = new Quarto { Nome = nome, Email = email, NumeroQuarto = numQuarto };
                    quarto[numQuarto] = q;
                }
                else
                {
                    Console.WriteLine("O quarto selecionado não se encontra disponível.");
                    Console.WriteLine("Informe novamente os dados e selecione outro quarto!");
                }
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < quarto.Length; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine(quarto[i]);
                }
            }
        }
    }
}