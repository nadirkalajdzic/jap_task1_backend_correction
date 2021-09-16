using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.DTO.Video
{

    public class VideoTypeDTO
    {
        public enum VideoTypes { movie, show }

        public VideoTypes VideoType { get; set; } = VideoTypes.movie;
    }
}
