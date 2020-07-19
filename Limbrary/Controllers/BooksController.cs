using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbrary.Models;
using Microsoft.AspNetCore.Mvc;
using Limbrary.DataAccess;
using Limbrary.ViewModels;

namespace Limbrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly LimbraryContext _context = new LimbraryContext();

        public IActionResult Search(string SearchTitle, string SearchAuthor)
        {
            var Name = _context.Books.Where(x => x.Title == SearchTitle && x.Author == SearchAuthor);
            var Model = new RandomBookViewModel
            {
                books = Name.ToList()
            };

            return View("Index", Model);
        }
        public IActionResult Random()
        {
            var viewModel = new RandomBookViewModel
            {
                Books = _context.Books.ToList()
            };
            return View("Index",viewModel);
        }

        public IActionResult Index()
        {

            RandomBookViewModel books = new RandomBookViewModel
            {
                books = _context.Books.ToList()

            };
            return View(books);
        }
    }
}
