using APIServiceLibrary.DTO.ProgramDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIServiceLibrary.DTO.EpisodeDTOs;

namespace APIServiceLibrary.Services
{
    public interface IAPIService
	{
		Task<ProgramResponseDTO> GetAllPrograms();

        Task<PodfilesResponseDTO> GetPodfilesByProgramId(int programID);

    }
}
