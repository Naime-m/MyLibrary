using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Data;
using MyLibrary.Models;
using System.Reflection.Metadata.Ecma335;

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
            Books = await _context.Books.ToListAsync();
                return View(Books);
        }
        public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Author,ReleaseDate")] Book book)
        {
            if (ModelState.IsValid)
            {
                 _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
