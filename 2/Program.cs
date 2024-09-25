//2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

namespace PesquisaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma String: ");

            string palavra = Console.ReadLine();

            int count = 0;

            foreach (char letra in palavra)
            {
                if (letra == 'A' || letra == 'a')
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Possui {count} letras 'A' na string informada! ");
            }
            else
            {
                Console.WriteLine("Não Possui 'A' na string informada! ");
            }
        }
    }
}
