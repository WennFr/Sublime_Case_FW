using System.ComponentModel.DataAnnotations;

namespace ProgramMVC.Models
{
    public class PodfilesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-M-d HH:mm}")]
        public string PublishDate { get; set; }
        public string Url { get; set; }
        public string Duration { get; set; }

    }
}
