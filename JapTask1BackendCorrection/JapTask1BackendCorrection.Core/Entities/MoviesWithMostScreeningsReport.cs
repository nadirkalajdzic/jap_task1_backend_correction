namespace JapTask1BackendCorrection.Core.Entities
{
    public class MoviesWithMostScreeningsReport : BaseEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int NumberOfScreenings { get; set; }
    }
}
