namespace MyFirstProject;

public class Exercicios
{
    public static void Exercicio1()
    {
        int? valueOne = null;
        int? valueTwo = null;
        Console.WriteLine("Exercicio 1 - Soma de inteiros");
        while (valueOne == null)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            try
            {
                valueOne = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }

        while (valueTwo == null)
        {
            Console.WriteLine("Digite o segundo valor: ");
            try
            {
                valueTwo = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }

        Console.WriteLine("A soma dos valores é: " + Calculate(valueOne.Value, valueTwo.Value).ToString());
    }

    private static int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Exercicio2()
    {
        int? number = null;
        Console.WriteLine("Exercicio 2 - Identificar numeros negativos");

        while (number == null)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }

        Console.WriteLine(number > 0 ? "Numero nao negativo" : "Numero negativo");
    }

    public static void Exercicio3()
    {
        string value = "2002";
        Console.WriteLine("Exercicio 3 - Verificar senha");

        while (true)
        {
            Console.WriteLine("Digite sua senha : ");
            if (Console.ReadLine() == value)
            {
                Console.WriteLine("Senha verificada");
                return;
            }

            Console.WriteLine("Senha incorreta");
        }
    }
}