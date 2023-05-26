using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using APIServiceLibrary.DTO.EpisodeDTOs;
using Newtonsoft.Json;
using APIServiceLibrary.DTO.ProgramDTOs;

namespace APIServiceLibrary.Services
{
    public class APIService : IAPIService
    {

        public async Task<ProgramResponseDTO> GetAllPrograms(int categoryId)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.sr.se");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var programs = new ProgramResponseDTO();

            HttpResponseMessage response =
                await client.GetAsync(
                    $"/api/v2/programs?format=json&indent=true&pagination=false&programcategoryid={categoryId}");

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                programs = JsonConvert.DeserializeObject<ProgramResponseDTO>(responseBody);
            }


            return programs;

        }

        public async Task<PodfilesResponseDTO> GetPodfilesByProgramId(int programId)
        {

            using var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.sr.se");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var podfiles = new PodfilesResponseDTO();

            HttpResponseMessage response = await client.GetAsync(
                $"http://api.sr.se/api/v2/podfiles?format=json&indent=true&pagination=false&programid={programId}");

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                podfiles = JsonConvert.DeserializeObject<PodfilesResponseDTO>(responseBody);
            }


            return podfiles;


        }

    }

}

