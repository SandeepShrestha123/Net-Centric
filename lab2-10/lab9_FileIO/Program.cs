using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            reader = new StreamReader("input.txt");
            writer = new StreamWriter("output.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string processed = line.ToUpper();
                writer.WriteLine(processed);
            }
            Console.WriteLine("File processed successfully!");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Error: input.txt not found. " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            if (reader != null) reader.Close();
            if (writer != null) writer.Close();
            Console.WriteLine("Cleanup done.");
        }
        Console.ReadKey();
    }
}