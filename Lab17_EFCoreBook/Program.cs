using Lab17_EFCoreBook;
using Microsoft.EntityFrameworkCore;

using (var db = new AppDbContext())
{
    db.Database.EnsureCreated();   

    // CREATE
    var book1 = new Book { Title = "C# in Depth", Author = "Jon Skeet", Price = 1500 };
    var book2 = new Book { Title = "Clean Code", Author = "Robert Martin", Price = 1200 };
    db.Books.AddRange(book1, book2);
    db.SaveChanges();
    Console.WriteLine("Books created.");

    // READ
    Console.WriteLine("\nAll books:");
    foreach (var b in db.Books.ToList())
    {
        Console.WriteLine(b.Id + " - " + b.Title + " by " + b.Author + " - Rs." + b.Price);
    }

    // UPDATE
    var bookToUpdate = db.Books.FirstOrDefault(b => b.Title == "Clean Code");
    if (bookToUpdate != null)
    {
        bookToUpdate.Price = 1350;
        db.SaveChanges();
        Console.WriteLine("\nUpdated price of 'Clean Code' to Rs.1350");
    }

    // DELETE
    var bookToDelete = db.Books.FirstOrDefault(b => b.Title == "C# in Depth");
    if (bookToDelete != null)
    {
        db.Books.Remove(bookToDelete);
        db.SaveChanges();
        Console.WriteLine("\nDeleted 'C# in Depth'");
    }

    Console.WriteLine("\nFinal book list:");
    foreach (var b in db.Books.ToList())
    {
        Console.WriteLine(b.Id + " - " + b.Title + " by " + b.Author + " - Rs." + b.Price);
    }
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();