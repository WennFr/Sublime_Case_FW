using Microsoft.AspNetCore.Mvc;
using ProgramMVC.Models;
using System.Diagnostics;
using APIServiceLibrary.DTO.EpisodeDTOs;
using APIServiceLibrary.Services;

namespace ProgramMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger, IAPIService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        private readonly ILogger<HomeController> _logger;
        private readonly IAPIService _apiService;
        private readonly List<PodfilesResponseDTO> AllPods;

        public async Task<IActionResult> Index()
        {
            var programsModel = await _apiService.GetAllPrograms();

            foreach (var program in programsModel.Programs)
            {
                var podfilesModel = await _apiService.GetAllPodfiles(program.Id);

                AllPods.Add(podfilesModel);
            }



            return View(programsModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}