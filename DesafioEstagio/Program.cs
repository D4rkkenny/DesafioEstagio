//1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
//escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence
//ou não a sequência.


namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero: ");

            int numero = int.Parse(Console.ReadLine());

            if (PertenciaFibonacci.PertenceFibonacci(numero))
            {
                Console.WriteLine("Pertence a sequencia de Fibonacci!");
            }
            else
            {
                Console.WriteLine("Não Pertence a sequencia de Fibonacci!");
            }
        }
    }
}
