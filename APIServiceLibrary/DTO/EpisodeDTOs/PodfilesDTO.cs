using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using APIServiceLibrary.DTO.ProgramDTOs;

namespace APIServiceLibrary.DTO.EpisodeDTOs
{
    public class PodfilesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDateUtc { get; set; }
        public string Url { get; set; }
        public int Duration { get; set; }
    }
}
