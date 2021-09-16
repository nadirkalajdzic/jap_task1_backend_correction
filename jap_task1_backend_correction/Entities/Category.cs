using System.Collections.Generic;

namespace jap_task1_backend_correction.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();
    }
}
