using MyFirstProject.models;

namespace MyFirstProject.exercicios;

public class BankExercise
{
    public static void Bank()
    {
        BankAccount bankAccount = new BankAccount(GetPersonName(), GetAccountNumber(), GetBalance());
        GetCurrentBankAccount(bankAccount);
        bankAccount.Balance = DepositValue();
        GetCurrentBankAccount(bankAccount);
        bankAccount.Balance -= WithdrawValue();
        GetCurrentBankAccount(bankAccount);
    }

    private static string GetAccountNumber()
    {
        string auxAccount = "";
        while (auxAccount == "")
        {
            Console.WriteLine("Digite o numero da conta: ");
            auxAccount = Console.ReadLine() ?? string.Empty;
            if (auxAccount == "")
                Console.WriteLine("Numero invalido");
        }

        return auxAccount;
    }

    private static string GetPersonName()
    {
        string auxPersonName = "";
        while (auxPersonName == "")
        {
            Console.WriteLine("Digite o nome do titular: ");
            auxPersonName = Console.ReadLine() ?? string.Empty;
            if (auxPersonName == "")
                Console.WriteLine("Numero invalido");
        }

        return auxPersonName;
    }

    private static float GetBalance()
    {
        float auxBalance = 0f;
        string option = "";
        while (option == "")
        {
            Console.WriteLine("Deseja realizar um deposito inicial? (S/N) ");
            option = Console.ReadLine() ?? string.Empty;
            if (!new List<string>() { "S", "N" }.Contains(option.ToUpper()))
            {
                Console.WriteLine("Valor invalido");
                option = "";
            }
        }

        if (option.ToUpper() == "N")
            return auxBalance;


        while (true)
        {
            Console.WriteLine("Digite um valor inicial: ");
            try
            {
                float.TryParse(Console.ReadLine(), out auxBalance);
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }

        return auxBalance;
    }

    private static float DepositValue()
    {
        float auxDepositValue = 0f;
        while (true)
        {
            Console.WriteLine("Digite um valor para adicionar: ");
            try
            {
                float.TryParse(Console.ReadLine(), out auxDepositValue);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }
        return auxDepositValue;
    }

    private static float WithdrawValue()
    {
        float auxWithdrawValue = 0f;
        while (true)
        {
            Console.WriteLine("Digite um valor para sacar: ");
            try
            {
                float.TryParse(Console.ReadLine(), out auxWithdrawValue);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor invalido");
            }
        }
        return auxWithdrawValue;
    }

    private static void GetCurrentBankAccount(BankAccount bankAccount)
    {
        Console.WriteLine($"Conta: {bankAccount.AccountNumber}, Titular: {bankAccount.Name}, Saldo: {bankAccount.Balance}");
    }
}