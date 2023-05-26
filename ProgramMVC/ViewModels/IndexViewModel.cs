using APIServiceLibrary.DTO.EpisodeDTOs;
using APIServiceLibrary.DTO.ProgramDTOs;

namespace ProgramMVC.ViewModels
{
    public class IndexViewModel
    {
        public ProgramResponseDTO ProgramResponse { get; set; }
        public List<PodfilesResponseDTO>PodfilesResponse { get; set; }

    }
}
