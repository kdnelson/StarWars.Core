using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWars.Dtos.Request.Planet;
using StarWars.Dtos.Request.Vehicle;
using StarWars.Interfaces.Planet;
using StarWars.Interfaces.Vehicle;
using StarWars.ViewModels.Planet;
using StarWars.ViewModels.Vehicle;

namespace StarWars.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanetHelper _planetHelper;
        private readonly IVehicleHelper _vehicleHelper;

        public HomeController(IPlanetHelper planetHelper,
            IVehicleHelper vehicleHelper)
        {
            _planetHelper = planetHelper;
            _vehicleHelper = vehicleHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetAllPlanets()
        {
            var response = new SearchPlanetViewModel();
            var planetGetRequestDto = new PlanetSearchRequestDto();  // All Planets
            response = await _planetHelper.SearchPlanetList(planetGetRequestDto);
            return View(response);
        }

        public async Task<ActionResult> GetPlanetTwentyTwo(int planetid)
        {
            var response = new GetPlanetViewModel();
            var planetGetRequestDto = new PlanetGetRequestDto() { Id = planetid };
            response = await _planetHelper.GetPlanet(planetGetRequestDto);
            return View(response);
        }

        public async Task<ActionResult> GetResidentsOfPlanetNaboo(string planetname)
        {
            var response = new List<SearchPlanetResidentsViewModel>();
            var planetSearchRequestDto = new PlanetSearchRequestDto() { Name = "Naboo" };
            //var planetSearchRequestDto = new PlanetSearchRequestDto();  // All Planet's Residents
            response = await _planetHelper.SearchPlanetResidentsList(planetSearchRequestDto);
            return View(response);
        }

        public async Task<ActionResult> VehicleSummary()
        {
            var response = new SearchVehicleViewModel();
            var vehicleSearchRequestDto = new VehicleSearchRequestDto();  // All Vehicles
            //var vehicleSearchRequestDto = new VehicleSearchRequestDto() { Name = "Sand Crawler" }; 
            response = await _vehicleHelper.SearchVehicleList(vehicleSearchRequestDto);
            return View(response);
        }
    }
}
