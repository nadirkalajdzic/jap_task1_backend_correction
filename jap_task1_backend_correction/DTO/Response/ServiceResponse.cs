using jap_task1_backend_correction.DTO.Video;
using System;
using System.Collections.Generic;

namespace jap_task1_backend_correction.Entities
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "Success";
    }
}
