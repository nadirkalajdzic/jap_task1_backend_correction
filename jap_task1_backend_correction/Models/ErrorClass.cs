using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Models
{
    public class ErrorClass
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
