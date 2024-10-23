namespace TargetSistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DesafioFibonacci tecnica1 = new DesafioFibonacci();

            MaiusculoMinusculo maiusculoMinusculo = new MaiusculoMinusculo();

            DesafioSoma desafioSoma = new DesafioSoma();

            Console.WriteLine($"Desafio \n [1] - Fibonacci \n [2] - Quantos 'a' ou 'A' possuem \n [3] - Soma \n  \n Escolha uma opção:");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    tecnica1.Fibonacci();
                    break;
                case 2:
                    maiusculoMinusculo.TestarMaiusculoMinusculo(); 
                    break;
                case 3:
                    desafioSoma.Desafio3(); 
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha 1, 2 ou 3."); 
                    break;
            }

        }
    }
}
