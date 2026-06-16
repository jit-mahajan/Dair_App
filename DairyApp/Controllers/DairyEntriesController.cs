using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
    public class DairyEntriesController : Controller
    {

        private readonly ApplicationDbContext _appDbContext;

        public DairyEntriesController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var dairyntry = _appDbContext.DairyEntries.ToList();
            return View(dairyntry);
        }

        [HttpPost]
        public IActionResult Create(DairyEntry dairyEntry)
        {
            _appDbContext.Add(dairyEntry);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
