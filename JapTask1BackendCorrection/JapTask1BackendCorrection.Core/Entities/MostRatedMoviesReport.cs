﻿namespace JapTask1BackendCorrection.Core.Entities
{
    public class MostRatedMoviesReport
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int NumberOfRatings { get; set; }
        public double AverageRating { get; set; }
    }
}
