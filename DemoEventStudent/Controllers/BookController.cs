using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoEventStudent.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace DemoEventStudent.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public async Task<IActionResult> Index()
        
        {
            var books = await bookRepository.Gets();
            return View(books);
        }
        //public async Task<IActionResult> Gets()
        //{
        //    var books = await bookRepository.Gets();
        //    return Ok(books);
        //}
    }
}
