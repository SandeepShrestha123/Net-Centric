using System;
class Student
{
    int roll, marks;
    string name;
    public Student(string name, int roll, int marks)
    {
        this.name = name;
        this.roll = roll;
        this.marks = marks;
    }
    public void display()
    {
        Console.WriteLine("Name: " + name + "\nRoll: " + roll + "\nMarks: " + marks);
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student("Sandeep", 13, 60);
        s.display();
    }
}
