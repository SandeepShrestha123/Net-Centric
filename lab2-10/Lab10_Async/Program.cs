using System;
using System.Threading.Tasks;
class Program
{
    static async Task DownloadFileAsync(string fileName, int seconds)
    {
        Console.WriteLine(fileName + " download started...");
        await Task.Delay(seconds * 1000);
        Console.WriteLine(fileName + " download completed.");
    }
    static async Task Main()
    {
        Task file1 = DownloadFileAsync("File1.zip", 3);
        Task file2 = DownloadFileAsync("File2.zip", 2);
        await Task.WhenAll(file1, file2);
        Console.WriteLine("Both downloads complete!");
        Console.ReadKey();
    }
}