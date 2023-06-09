﻿using Microsoft.AspNetCore.Mvc;
using ProgramMVC.Models;
using System.Diagnostics;
using APIServiceLibrary.DTO.EpisodeDTOs;
using APIServiceLibrary.Services;
using AutoMapper;
using ProgramMVC.ViewModels;
using UtilityServiceLibrary.Services;

namespace ProgramMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger, IAPIService apiService, IMapper mapper, IUtilityService utilityService)
        {
            _logger = logger;
            _apiService = apiService;
            _mapper = mapper;
            _utilityService = utilityService;
        }

        private readonly ILogger<HomeController> _logger;
        private readonly IAPIService _apiService;
        private readonly IMapper _mapper;
        private readonly IUtilityService _utilityService;

        public async Task<IActionResult> Index()
        {
            var categoryId = 133;
            var pageNo = 1;
            var size = 3;

            var programResponse = await _apiService.GetAllPrograms(categoryId);
            var programModels = _mapper.Map<List<ProgramModel>>(programResponse.Programs)
                .OrderBy(p => p.Channel.Name)
                .ToList();

            foreach (var programModel in programModels)
            {
                var podfileResponse = await _apiService.GetPodfilesByProgramId(programModel.Id, pageNo, size);
                programModel.Podfiles = podfileResponse.Podfiles.Select(p => new PodfilesModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    PublishDate = _utilityService.ConvertToLocaleDateTime(p.PublishDateUtc),
                    Url = p.Url,
                    Duration = _utilityService.ConvertSecondsToCompleteDuration(p.Duration)
                }).ToList();
            }


            var indexViewModel = new IndexViewModel();
            indexViewModel.Programs = programModels;


            return View(indexViewModel);
        }

        public async Task<IActionResult> Program(int programId)
        {
            var categoryId = 133;
            var pageNo = 1;
            var size = 1000;


            var programResponse = await _apiService.GetAllPrograms(categoryId);
            var programModels = _mapper.Map<List<ProgramModel>>(programResponse.Programs);
            var programModel = programModels.FirstOrDefault(p => p.Id == programId);

            var podfileResponse = await _apiService.GetPodfilesByProgramId(programModel.Id, pageNo, size);

            programModel.Podfiles = podfileResponse.Podfiles.Select(p => new PodfilesModel
            {
                Id = p.Id,
                Title = p.Title,
                PublishDate = _utilityService.ConvertToLocaleDateTime(p.PublishDateUtc),
                Url = p.Url,
                Duration = _utilityService.ConvertSecondsToCompleteDuration(p.Duration)
            }).ToList();

            var programViewModel = new ProgramViewModel();
            programViewModel.Program = programModel;

            return View(programViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}