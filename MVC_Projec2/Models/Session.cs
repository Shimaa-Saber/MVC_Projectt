namespace MVC_Projec2.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public List<SessionImages> Images { get; set; } = new List<SessionImages>();

    }
}
