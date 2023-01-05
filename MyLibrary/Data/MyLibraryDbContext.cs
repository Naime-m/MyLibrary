using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;

namespace MyLibrary.Data;

public class MyLibraryDbContext: DbContext
{
	public MyLibraryDbContext(DbContextOptions options) : base(options)
	{
	}

	public DbSet<Book> Books { get; set; }
}
