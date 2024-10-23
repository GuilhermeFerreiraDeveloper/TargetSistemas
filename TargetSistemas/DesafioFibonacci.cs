using System;

namespace TargetSistemas
{
    public class DesafioFibonacci
    {
        public void Fibonacci()
        {
            Console.WriteLine("Digite o número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            bool pertence = FibonacciMetodo(numero1);

            if (pertence)
            {
                Console.WriteLine("O número " + numero1 + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número " + numero1 + " não pertence à sequência de Fibonacci.");
            }
        }

        private bool FibonacciMetodo(int numeroRecebido)
        {
            int primeiroNumero = 0;
            int segundoNumero = 1; 

            // Se o número for 0 ou 1 retorna verdadeiro
            if (numeroRecebido == primeiroNumero || numeroRecebido == segundoNumero)
            {
                return true;
            }

            // Gera a sequência até ultrapassar o número informado
            while (segundoNumero <= numeroRecebido)
            {
                int next = primeiroNumero + segundoNumero; 
                primeiroNumero = segundoNumero;            // Atualiza a
                segundoNumero = next;        // Atualiza b

                // Se b for igual ao numero retorna verdadeiro
                if (segundoNumero == numeroRecebido){
                    return true;
                }
            }



            return false;
        }
    }
}
