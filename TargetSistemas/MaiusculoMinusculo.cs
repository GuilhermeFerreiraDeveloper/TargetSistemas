using System;

namespace TargetSistemas
{
    internal class MaiusculoMinusculo
    {

        public void TestarMaiusculoMinusculo()
        {
            Console.WriteLine("Digite o texto que será verificado quandos 'a' ou 'A' possue: ");
            string input = Console.ReadLine();  

            string resultado = VerificarLetraA(input);
            Console.WriteLine(resultado);
        }

        // Método 
        private string VerificarLetraA(string texto)
        {
            int count = 0;

            foreach (char c in texto)
            {
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            if (count > 0)
            {
                return $"A letra 'a' (maiúscula ou minúscula) existe na string e ocorre {count} vez(es).";
            }
            else
            {
                return "A letra 'a' (maiúscula ou minúscula) não existe na string.";
            }
        }
    }
}
