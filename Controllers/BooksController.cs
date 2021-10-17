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

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("/released/{year:regex(^\\d{{4}}$):min(1925):max(2021)}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
