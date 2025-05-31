namespace MyFirstProject.models;

public class BankAccount
{
    private string personName;
    private string accountNumber;
    private float balance;

    public string Name
    {
        get => personName;
        set => personName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string AccountNumber
    {
        get => accountNumber;
        set => accountNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Balance
    {
        get => balance;
        set => balance = value;
    }


    public BankAccount(string personName, string accountNumber, float balance)
    {
        this.personName = personName;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
}