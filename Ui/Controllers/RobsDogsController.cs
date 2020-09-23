using System.Web.Mvc;
using Ui.Services;
using Ui.ViewModelMappers;

namespace Ui.Controllers
{
    public class RobsDogsController : Controller
    {
        DogOwnerService dogOwnerService;
        public RobsDogsController(DogOwnerService dogOwnerService)
        {
            this.dogOwnerService = dogOwnerService;
        }

        public RobsDogsController() :this(new DogOwnerService())
        {
           
        }

        // GET: RobsDogs
        public ActionResult Index()
        {
			var dogOwnerViewModelMapper = new DogOwnerViewModelMapper(dogOwnerService);
	        var dogOwnerListViewModel = dogOwnerViewModelMapper.GetAllDogOwners();

            return View(dogOwnerListViewModel);
        }
    }
}