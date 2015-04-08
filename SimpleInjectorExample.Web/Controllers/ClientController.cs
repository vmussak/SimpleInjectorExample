using System.Web.Mvc;
using SimpleInjectorExample.Business;

namespace SimpleInjectorExample.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var model = _service.Get();
            return View(model);
        }
	}
}