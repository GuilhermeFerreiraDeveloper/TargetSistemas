using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSistemas
{
    internal class DesafioSoma
    {
        public void Desafio3()
        {
            int INDICE = 12, SOMA = 0, K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
        }

    }
}
