using System.Text.Json.Serialization;

namespace JapTask1BackendCorrection.Core.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaEnum
    {
        Movie = 0, 
        Show = 1
    }
}
