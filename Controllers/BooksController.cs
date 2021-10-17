using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetWSEI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetWSEI.Controllers
{
    public class BooksController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English" };
            return View(firstBook);
        }
    }
}
