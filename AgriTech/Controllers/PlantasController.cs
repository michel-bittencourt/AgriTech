using Microsoft.AspNetCore.Mvc;
using AgriTech.Models;
using AgriTech.Services;
using Microsoft.EntityFrameworkCore;

namespace AgriTech.Controllers
{
    public class PlantasController : Controller
    {
        private readonly PlantaService _plantaService;

        public PlantasController(PlantaService plantaService)
        {
            _plantaService = plantaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = _plantaService.FindAll();
            return View(list);
        }
        public async Task<IActionResult> Details(int id)
        {
            var list = _plantaService.FindById(id);
            return View(list);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Planta planta)
        {

            _plantaService.Insert(planta);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _plantaService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            _plantaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
