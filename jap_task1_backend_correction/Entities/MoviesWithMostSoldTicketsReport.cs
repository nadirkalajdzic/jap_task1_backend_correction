namespace JapTask1BackendCorrection.Entities
{
    public class MoviesWithMostSoldTicketsReport : BaseEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string ScreeningName { get; set; }
        public int SoldTickets { get; set; }
    }
}
