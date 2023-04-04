using Microsoft.AspNetCore.Mvc;
using AgriTech.Models;
using AgriTech.Services;

namespace AgriTech.Controllers
{
    public class PlantasController : Controller
    {
        private readonly PlantaService _PlantaService;

        public PlantasController(PlantaService plantaService)
        {
            _PlantaService = plantaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = _PlantaService.FindAll();
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
            _PlantaService.Insert(planta);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _PlantaService.FindById(id.Value);

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
            _PlantaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
