using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Data;
using MyLibrary.Models;

namespace MyLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly MyLibraryDbContext _context;

        public BooksController(MyLibraryDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.ToListAsync();
                return View(books);
        }

        public IEnumerable<Book> Books { get; set; }
    }
}
