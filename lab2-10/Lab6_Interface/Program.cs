using System;
using System.Collections.Generic;

interface IPayable
{
    void Pay();
}

class Invoice : IPayable
{
    private string invoiceNo;
    private double amount;

    public Invoice(string invoiceNo, double amount)
    {
        this.invoiceNo = invoiceNo;
        this.amount = amount;
    }

    public void Pay()
    {
        Console.WriteLine("Paying Invoice " + invoiceNo + ": $" + amount);
    }
}

class Salary : IPayable
{
    private string employeeName;
    private double amount;

    public Salary(string employeeName, double amount)
    {
        this.employeeName = employeeName;
        this.amount = amount;
    }

    public void Pay()
    {
        Console.WriteLine("Paying Salary to " + employeeName + ": $" + amount);
    }
}

class Program
{
    static void Main()
    {
        List<IPayable> payables = new List<IPayable>();
        payables.Add(new Invoice("INV001", 1500.50));
        payables.Add(new Salary("Sandeep", 4000));
        payables.Add(new Invoice("INV002", 750));

        foreach (IPayable p in payables)
        {
            p.Pay();
        }

        Console.ReadKey();
    }
}