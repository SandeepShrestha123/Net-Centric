using System;

class MyStack<T>
{
    private T[] items;
    private int top;
    private int capacity;

    public MyStack(int size = 10)
    {
        capacity = size;
        items = new T[capacity];
        top = -1;
    }

    public void Push(T value)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack full!");
            return;
        }
        items[++top] = value;
    }

    public T Pop()
    {
        if (top == -1)
            throw new InvalidOperationException("Stack empty!");
        return items[top--];
    }
    public T Peek()
    {
        if (top == -1)
            throw new InvalidOperationException("Stack empty!");
        return items[top];
    }
    public bool IsEmpty()
    {
        return top == -1;
    }
}

class Program
{
    static void Main()
    {
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine("Int Peek: " + intStack.Peek());
        Console.WriteLine("Int Pop: " + intStack.Pop());
        Console.WriteLine("Int Pop: " + intStack.Pop());
        MyStack<string> strStack = new MyStack<string>();
        strStack.Push("Hello");
        strStack.Push("World");
        Console.WriteLine("String Peek: " + strStack.Peek());
        Console.WriteLine("String Pop: " + strStack.Pop());
        Console.ReadKey();
    }
}