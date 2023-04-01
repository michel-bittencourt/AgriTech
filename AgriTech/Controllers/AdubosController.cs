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
    }
}
