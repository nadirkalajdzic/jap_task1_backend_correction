using System;

namespace jap_task1_backend_correction.DTO.Video
{
    public class GetVideoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image_Url { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float AverageRating { get; set; } = 0;
    }
}
