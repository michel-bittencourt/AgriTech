using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgriTech.Data;
using AgriTech.Models;
using AgriTech.Services;
using AgriTech.Models.ViewModel;

namespace AgriTech.Controllers
{
    public class AdubosController : Controller
    {
        private readonly AduboService _aduboService;

        public AdubosController(AduboService aduboService)
        {
            _aduboService = aduboService;
        }

        //Retorna todos os item do db Adubo
        public async Task<IActionResult> Index()
        {
            var list = _aduboService.FindAll();
            return View(list);
        }

        //Retorna pagina com os detalhes do Adubo especifico
        public async Task<IActionResult> Details(int id)
        {
            var list = _aduboService.FindById(id);
            return View(list);
        }

        //Retorna a pagina para criar um novo Adubo no db
        public async Task<IActionResult> Create()
        {
            return View();
        }

        //Realiza a criar de um novo Adubo no db
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Adubo adubo)
        {
            _aduboService.Insert(adubo);
            return RedirectToAction(nameof(Index));
        }



        //Retorna a pagina de exclusao um novo Adubo no db
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

        //Realiza a exclusao de um Adubo especifico do db
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            _aduboService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
