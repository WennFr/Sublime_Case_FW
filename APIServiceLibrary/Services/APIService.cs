using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using APIServiceLibrary.DTO;
using Newtonsoft.Json;

namespace APIServiceLibrary.Services
{
	public class APIService
	{



		public static async Task<ProgramResponse> GetAllPrograms()
		{
			using var client = new HttpClient();
			client.BaseAddress = new Uri("http://api.sr.se");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


			var programs = new ProgramResponse();

			HttpResponseMessage response = await client.GetAsync("/api/v2/programs?format=json&indent=true&pagination=false&programcategoryid=133");

			if (response.IsSuccessStatusCode)
			{
				var responseBody = await response.Content.ReadAsStringAsync();
				programs = JsonConvert.DeserializeObject<ProgramResponse>(responseBody);
			}


			return programs;

		}





	}



	}
}
