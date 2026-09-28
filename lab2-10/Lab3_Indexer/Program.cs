using System;
class Week
{
    private string[] days = new string[7];
    public string this[int index]
    {
        get { return days[index]; }
        set { days[index] = value; }
    }
}
class Program
{
    static void Main()
    {
        Week w = new Week();
        w[0] = "Sunday";
        w[1] = "Monday";
        w[2] = "Tuesday";
        w[3] = "Wednesday";
        w[4] = "Thursday";
        w[5] = "Friday";
        w[6] = "Saturday";
        Console.WriteLine("Days stored in the indexers are: ");
        for (int i = 0; i < 7; i++)
            Console.WriteLine(w[i]);
    }
}
