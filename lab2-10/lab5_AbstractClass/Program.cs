using System;

abstract class Employee
{
    public string Name;
    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();

    public void Display()
    {
        Console.WriteLine(Name + " Salary: " + CalculateSalary());
    }
}

class Manager : Employee
{
    private double baseSalary;
    private double bonus;
    public Manager(string name, double baseSalary, double bonus) : base(name)
    {
        this.baseSalary = baseSalary;
        this.bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return baseSalary + bonus;
    }
}

class Clerk : Employee
{
    private double hourlyRate;
    private int hoursWorked;

    public Clerk(string name, double hourlyRate, int hoursWorked) : base(name)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }
    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }
}

class Program
{
    static void Main()
    {
        Employee m = new Manager("Sandeep", 50000, 5000);
        Employee c = new Clerk("Srestaa", 20, 160);

        m.Display();
        c.Display();

        Console.ReadKey();
    }
}