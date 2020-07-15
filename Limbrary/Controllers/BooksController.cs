using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Limbrary.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Random()
        {
            var book = new Books() { Title = "The Secret Garden" };
            return View(book);
        }
    }
}
