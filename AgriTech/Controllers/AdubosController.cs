using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgriTech.Data;
using AgriTech.Models;
using AgriTech.Services;

namespace AgriTech.Controllers
{
    public class AdubosController : Controller
    {
        private readonly AduboService _aduboService;

        public AdubosController(AduboService aduboService)
        {
            _aduboService = aduboService;
        }

        public async Task<IActionResult> Index()
        {
            var list = _aduboService.FindAll();
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Adubo adubo)
        {
            _aduboService.Insert(adubo);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _aduboService.FindById(id.Value);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            _aduboService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
