namespace MVC_Projec2.Models
{
    public class MakeUpImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int MakeUpId { get; set; }
        public MakeUp_Service makeUp { get; set; }
    }
}
