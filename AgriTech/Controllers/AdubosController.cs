using Microsoft.AspNetCore.Mvc;
using AgriTech.Models;
using AgriTech.Services;
using AgriTech.Services.Exceptions;

namespace AgriTech.Controllers
{
    public class AdubosController : Controller
    {
        private readonly AduboService _aduboService;

        public AdubosController(AduboService aduboService)
        {
            _aduboService = aduboService;
        }
        //--------------------------------------------------------------------
        //Retorna a pagina com todos os item do banco
        public async Task<IActionResult> Index()
        {
            var list = _aduboService.FindAll();
            return View(list);
        }
        //--------------------------------------------------------------------
        //Retorna a pagina com os detalhes de um item especifico
        public async Task<IActionResult> Details(int id)
        {
            var list = _aduboService.FindById(id);
            return View(list);
        }
        //--------------------------------------------------------------------
        //Retorna a pagina para criar um novo item
        public async Task<IActionResult> Create()
        {
            return View();
        }
        //--------------------------------------------------------------------
        //Realiza a criacao de um novo Adubo no banco
        //HttpPost cria um metodo POST para envio
        /*ValidateAntiForgeryToken é uma medida de segurança para prevenir ataques CSRF, que garante que um formulário enviado para o servidor seja o mesmo que foi exibido para o usuário, através do uso de um token de validação exclusivo.*/
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Create(Adubo adubo)
        {
            _aduboService.Insert(adubo);
            return RedirectToAction(nameof(Index));
        }
        //--------------------------------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _aduboService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //--------------------------------------------------------------------
        //HttpPost cria um metodo POST para envio
        /*ValidateAntiForgeryToken é uma medida de segurança para prevenir ataques CSRF, que garante que um formulário enviado para o servidor seja o mesmo que foi exibido para o usuário, através do uso de um token de validação exclusivo.*/
        [HttpPost] //Cria um metodo POST par envio
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Adubo adubo)
        {
            if (id != adubo.Id)
            {
                return BadRequest();
            }

            try
            {
                _aduboService.Update(adubo);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (DbConcurrencyException e)
            {
                return BadRequest();
            }
        }
        //--------------------------------------------------------------------
        //Retorna a pagina de exclusao um novo Adubo no db
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _aduboService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //--------------------------------------------------------------------
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
