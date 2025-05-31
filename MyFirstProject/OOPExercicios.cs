using MyFirstProject.models;

namespace MyFirstProject;

public class OOPExercicios
{
    public static void Exercicio1()
    {
        Person firstPerson = new Person(GetName(), GetAge());
        Person secondPerson = new Person(GetName(), GetAge());

        if (firstPerson.GetAge() > secondPerson.GetAge())
            Console.WriteLine($"{firstPerson.GetName()} é a pessoa mais velha, com {firstPerson.GetAge()} anos.");
        else if (firstPerson.GetAge() < secondPerson.GetAge())
            Console.WriteLine($"{secondPerson.GetName()} é a pessoa mais velha, com {secondPerson.GetAge()} anos.");
        else
            Console.WriteLine($"{firstPerson.GetName()} e {secondPerson.GetName()} tem a mesma idade");
    }

    public static void Exercicio2()
    {
        Person firstPerson = new Person(GetName(), GetSalary());
        Person secondPerson = new Person(GetName(), GetSalary());

        Console.WriteLine($"A media de salarios é de {(firstPerson.GetSalary() + secondPerson.GetSalary()) / 2}");
    }

    private static string GetName()
    {
        string auxName = "";
        while (true)
        {
            Console.WriteLine("Digite um nome: ");
            auxName = Console.ReadLine();
            if (!string.IsNullOrEmpty(auxName))
            {
                break;
            }

            Console.WriteLine("Nome invalido");
        }

        return auxName;
    }

    private static int GetAge()
    {
        int auxAge = 0;
        while (true)
        {
            Console.WriteLine("Digite uma idade: ");
            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine("Idade invalida");
            }

            auxAge = int.Parse(Console.ReadLine());
            if (auxAge > 0) break;

            Console.WriteLine("Nome invalido");
        }

        return auxAge;
    }

    private static float GetSalary()
    {
        float auxSalary = 0;
        while (true)
        {
            Console.WriteLine("Digite um salario: ");
            try
            {
                auxSalary = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }

            if (auxSalary > 0) break;

            Console.WriteLine("Valor negativo");
        }

        return auxSalary;
    }
}