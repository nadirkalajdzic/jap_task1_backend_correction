using System;

namespace JapTask1BackendCorrection.Core.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "SYSTEM";
        public DateTime? ArchivedAt { get; set; } = null;
        public string ArchivedBy { get; set; } = null;
         
    }
}
