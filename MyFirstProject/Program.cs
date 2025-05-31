
using MyFirstProject.exercicios;

namespace MyFirstProject
{
    class Program
    {
        private static void Main(string[] args)
        {
            int? option = null;
            Console.WriteLine("Hello World!");
            while (option == null)
            {
                Console.WriteLine("Qual exercicio quer executar?");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor invalido");
                }
            }

            switch (option)
            {
                case 1:
                    Exercicios.Exercicio1();
                    break;
                case 2:
                    Exercicios.Exercicio2();
                    break;
                case 3:
                    Exercicios.Exercicio3();
                    break;
                case 4:
                    Exercicios.Exercicio4();
                    break;
                case 5:
                    OOPExercicios.Exercicio1();
                    break;
                case 6:
                    OOPExercicios.Exercicio2();
                    break;
                case 7:
                    BankExercise.Bank();
                    break;
                default:
                    Console.WriteLine("Valor invalido, desligando...");
                    break;
            }
        }
    }
}