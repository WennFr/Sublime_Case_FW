using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceLibrary.DTO
{
	public class Program
	{
		public int Id { get; set; }
		public ProgramCategory ProgramCategory { get; set; }
		public Channel Channel { get; set; }
		public string Name { get; set; }
        public string ProgramImage { get; set; }
        public string Description { get; set; }
	}
}
