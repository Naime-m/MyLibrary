using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models;

public class Book
{
    public int Id { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 3)]
    public string Title { get; set; }
    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string Description { get; set; }
    [Required]
    public string Author { get; set; }
    
    [DisplayName("Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public Category Category { get; set; }

}

public enum Category
{
    Fiction,
    [Display(Name = "Non Fiction")]
    NonFiction
}
