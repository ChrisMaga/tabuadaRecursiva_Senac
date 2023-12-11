using System;

namespace TabuadaRecursiva
{
    class Program
    {
        // Função recursiva que imprime a tabuada de um número
        static void Tabuada(int numero, int multiplicador, int limite)
        {
            //// Caso base: se o multiplicador for maior que o limite, termina a recursão
            if (multiplicador > limite)
            {
                return;
            }
            // Passo recursivo: imprime o resultado da multiplicação e chama a função novamente com o multiplicador incrementado
            Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
            Tabuada(numero, multiplicador + 1, limite);
        }

        static void Main(string[] args)
        {
            // Pede ao usuário que digite um número entre 1 e 10
            Console.WriteLine("Digite um número entre 1 e 10 para ver a sua tabuada:");
            // Converte a entrada do usuário em um inteiro
            int numero = int.Parse(Console.ReadLine());
            // Valida se o número está entre 1 e 10
            if (numero < 1 || numero > 10)
            {
                // Se não estiver, mostra uma mensagem de erro e encerra o programa
                Console.WriteLine("Número inválido. Digite um número entre 1 e 10.");
                return;
            }
            // Se estiver, chama a função recursiva para imprimir a tabuada do número até 10
            Tabuada(numero, 0, 10);
        }
    }
}

