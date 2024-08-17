using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Microsoft.AspNetCore.Components;
using Presentation.Repository;

namespace Filbert_Chepurin.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _peopleRepository;


        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        // GET: получим людей и подтянем таблицы, связанные с людьми
        public async Task<IActionResult> Index()
        {
            var persons = _peopleRepository.GetAllInformationAsync();

            return View(persons);
        }

        [Microsoft.AspNetCore.Mvc.Route("/NotFound")]
        public IActionResult PageNotFound()
        {
            return View();
        }

    }
}
