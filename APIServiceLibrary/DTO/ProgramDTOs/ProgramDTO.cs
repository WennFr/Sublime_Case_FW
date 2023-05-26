using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceLibrary.DTO.ProgramDTOs
{
    public class ProgramDTO
    {
        public int Id { get; set; }
        public ProgramCategoryDTO ProgramCategory { get; set; }
        public ChannelDTO Channel { get; set; }
        public string Name { get; set; }
        public string ProgramImage { get; set; }
        public string Description { get; set; }
    }
}
