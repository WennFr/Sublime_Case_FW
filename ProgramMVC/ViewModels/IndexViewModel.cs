using APIServiceLibrary.DTO.EpisodeDTOs;
using APIServiceLibrary.DTO.ProgramDTOs;
using ProgramMVC.Models;

namespace ProgramMVC.ViewModels
{
    public class IndexViewModel
    {
        public List<ProgramModel> Programs { get; set; }
    }
}
