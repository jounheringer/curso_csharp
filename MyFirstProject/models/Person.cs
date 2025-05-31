namespace MyFirstProject.models;

public class Person
{
    private string name;
    private int age;
    private float salary;

    public Person(string name, int age)
    {
        SetName(name);
        SetAge(age);
        this.salary = 0f;
    }
    public Person(string name, float salary)
    {
        SetName(name);
        SetSalary(salary);
        this.age = 0;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
    public void SetSalary(float salary)
    {
        this.salary = salary;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetAge()
    {
        return this.age;
    }

    public float GetSalary()
    {
        return this.salary;
    }
}