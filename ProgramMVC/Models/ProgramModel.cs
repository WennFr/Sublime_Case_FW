namespace ProgramMVC.Models
{
    public class ProgramModel
    {
        public int Id { get; set; }
    
        public string Name { get; set; }
        public string ProgramImage { get; set; }
        public string Description { get; set; }
        public ProgramCategoryModel ProgramCategory { get; set; }
        public ChannelModel Channel { get; set; }
        public List<PodfilesModel> Podfiles { get; set; }

    }
}
