
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
                default:
                    Console.WriteLine("Valor invalido, desligando...");
                    break;
            }
        }
    }
}