using APIServiceLibrary.DTO.ProgramDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceLibrary.Services
{
    public interface IAPIService
	{
		Task<ProgramResponseDTO> GetAllPrograms();


	}
}
