using System.ComponentModel;

namespace MyLibrary.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string ReleaseDate { get; set; }

    public Category Category { get; set; }

}

public enum Category
{
    Fiction,
    NonFiction
}
