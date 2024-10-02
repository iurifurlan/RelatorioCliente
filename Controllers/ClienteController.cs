using Microsoft.AspNetCore.Mvc;
using RelatorioCliente.Data;
using RelatorioCliente.Models;

namespace RelatorioCliente.Controllers
{
    public class ClienteController : Controller
    {

        readonly private ApplicationDbContext _db;
        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ClientesModel> clientes = _db.Clientes;

            return View(clientes);
        }
    }
}
