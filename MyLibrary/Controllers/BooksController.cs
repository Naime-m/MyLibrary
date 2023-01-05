using Microsoft.AspNetCore.Mvc;
using MyLibrary.Data;

namespace MyLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly MyLibraryDbContext _context;

        public BooksController(MyLibraryDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
