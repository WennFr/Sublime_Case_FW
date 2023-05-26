namespace ProgramMVC.Models
{
    public class PodfilesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDateUtc { get; set; }
        public string Url { get; set; }
        public int Duration { get; set; }

    }
}
