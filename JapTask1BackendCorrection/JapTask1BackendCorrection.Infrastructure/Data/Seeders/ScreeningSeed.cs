﻿using JapTask1BackendCorrection.Core.Entities;
using System;
using System.Collections.Generic;

namespace JapTask1BackendCorrection.Data.Seeders
{
    public class ScreeningSeed
    {
        public static List<Screening> Screenings { get; } = new()
        {
            new Screening { Id = 1, Name = "Screening 1", MediaId = 1, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 2, Name = "Screening 2", MediaId = 2, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 3, Name = "Screening 3", MediaId = 3, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 4, Name = "Screening 4", MediaId = 4, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 5, Name = "Screening 5", MediaId = 5, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 6, Name = "Screening 6", MediaId = 6, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 7, Name = "Screening 7", MediaId = 7, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 8, Name = "Screening 8", MediaId = 8, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 9, Name = "Screening 9", MediaId = 9, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 10, Name = "Screening 10", MediaId = 10, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 11, Name = "Screening 11", MediaId = 11, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 12, Name = "Screening 12", MediaId = 12, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 13, Name = "Screening 13", MediaId = 13, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 14, Name = "Screening 14", MediaId = 14, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 15, Name = "Screening 15", MediaId = 15, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 16, Name = "Screening 16", MediaId = 16, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 17, Name = "Screening 17", MediaId = 17, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 18, Name = "Screening 18", MediaId = 18, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 19, Name = "Screening 19", MediaId = 19, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 20, Name = "Screening 20", MediaId = 20, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 21, Name = "Screening 21", MediaId = 21, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 22, Name = "Screening 22", MediaId = 22, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 23, Name = "Screening 23", MediaId = 23, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 24, Name = "Screening 24", MediaId = 24, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 25, Name = "Screening 25", MediaId = 25, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 26, Name = "Screening 26", MediaId = 26, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 27, Name = "Screening 27", MediaId = 27, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 28, Name = "Screening 28", MediaId = 28, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 29, Name = "Screening 29", MediaId = 29, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 30, Name = "Screening 30", MediaId = 30, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 31, Name = "Screening 31", MediaId = 31, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 32, Name = "Screening 32", MediaId = 32, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 33, Name = "Screening 33", MediaId = 33, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 34, Name = "Screening 34", MediaId = 34, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 35, Name = "Screening 35", MediaId = 35, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 36, Name = "Screening 36", MediaId = 36, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 37, Name = "Screening 37", MediaId = 37, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 38, Name = "Screening 38", MediaId = 38, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 39, Name = "Screening 39", MediaId = 39, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 40, Name = "Screening 40", MediaId = 40, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 41, Name = "Screening 41", MediaId = 41, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 42, Name = "Screening 42", MediaId = 42, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 43, Name = "Screening 43", MediaId = 43, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 44, Name = "Screening 44", MediaId = 44, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 45, Name = "Screening 45", MediaId = 45, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 46, Name = "Screening 46", MediaId = 46, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 47, Name = "Screening 47", MediaId = 47, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 48, Name = "Screening 48", MediaId = 48, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 49, Name = "Screening 49", MediaId = 49, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 50, Name = "Screening 50", MediaId = 50, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 51, Name = "Screening 51", MediaId = 51, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 52, Name = "Screening 52", MediaId = 52, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 53, Name = "Screening 53", MediaId = 53, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 54, Name = "Screening 54", MediaId = 54, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 55, Name = "Screening 55", MediaId = 55, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 56, Name = "Screening 56", MediaId = 56, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 57, Name = "Screening 57", MediaId = 57, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 58, Name = "Screening 58", MediaId = 58, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 59, Name = "Screening 59", MediaId = 59, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 60, Name = "Screening 60", MediaId = 60, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 61, Name = "Screening 61", MediaId = 61, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 62, Name = "Screening 62", MediaId = 62, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 63, Name = "Screening 63", MediaId = 63, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 64, Name = "Screening 64", MediaId = 64, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 65, Name = "Screening 65", MediaId = 65, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 66, Name = "Screening 66", MediaId = 66, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 67, Name = "Screening 67", MediaId = 67, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 68, Name = "Screening 68", MediaId = 68, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 69, Name = "Screening 69", MediaId = 69, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 70, Name = "Screening 70", MediaId = 70, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 71, Name = "Screening 71", MediaId = 71, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 72, Name = "Screening 72", MediaId = 72, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 73, Name = "Screening 73", MediaId = 73, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 74, Name = "Screening 74", MediaId = 74, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 75, Name = "Screening 75", MediaId = 75, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 76, Name = "Screening 76", MediaId = 76, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 77, Name = "Screening 77", MediaId = 77, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 78, Name = "Screening 78", MediaId = 78, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 79, Name = "Screening 79", MediaId = 79, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 80, Name = "Screening 80", MediaId = 80, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 81, Name = "Screening 81", MediaId = 81, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 82, Name = "Screening 82", MediaId = 82, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 83, Name = "Screening 83", MediaId = 83, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 84, Name = "Screening 84", MediaId = 84, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 85, Name = "Screening 85", MediaId = 85, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 },
            new Screening { Id = 86, Name = "Screening 86", MediaId = 86, AvailableTickets = 12, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20), Duration = 200 },
            new Screening { Id = 87, Name = "Screening 87", MediaId = 87, AvailableTickets = 13, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10), Duration = 100 },
            new Screening { Id = 88, Name = "Screening 88", MediaId = 88, AvailableTickets = 14, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5), Duration = 400 },
            new Screening { Id = 89, Name = "Screening 89", MediaId = 89, AvailableTickets = 15, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1), Duration = 500 },
            new Screening { Id = 90, Name = "Screening 90", MediaId = 90, AvailableTickets = 16, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10), Duration = 320 },
            new Screening { Id = 91, Name = "Screening 91", MediaId = 91, AvailableTickets = 10, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30), Duration = 40 },
            new Screening { Id = 92, Name = "Screening 92", MediaId = 92, AvailableTickets = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29), Duration = 50 },
            new Screening { Id = 93, Name = "Screening 93", MediaId = 93, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 94, Name = "Screening 94", MediaId = 94, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 95, Name = "Screening 95", MediaId = 95, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 96, Name = "Screening 96", MediaId = 96, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 97, Name = "Screening 97", MediaId = 97, AvailableTickets = 102, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1), Duration = 310 },
            new Screening { Id = 98, Name = "Screening 98", MediaId = 98, AvailableTickets = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21), Duration = 200 },
            new Screening { Id = 99, Name = "Screening 99", MediaId = 99, AvailableTickets = 10, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10), Duration = 210 },
            new Screening { Id = 100, Name = "Screening 100", MediaId = 100, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1), Duration = 220 },
            new Screening { Id = 101, Name = "Screening 101", MediaId = 100, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0), Duration = 220 },
            new Screening { Id = 102, Name = "Screening 102", MediaId = 100, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0), Duration = 220 },
            new Screening { Id = 103, Name = "Screening 103", MediaId = 100, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0), Duration = 220 },
            new Screening { Id = 104, Name = "Screening 104", MediaId = 104, AvailableTickets = 22, SoldTickets = 22, ScreeningDate = new DateTime(2015, 1, 1, 0, 0, 0, 0), Duration = 120 },
            new Screening { Id = 105, Name = "Screening 105", MediaId = 105, AvailableTickets = 22, SoldTickets = 21, ScreeningDate = new DateTime(2021, 1, 1, 0, 0, 0, 0), Duration = 100 },
            new Screening { Id = 106, Name = "Screening 106", MediaId = 106, AvailableTickets = 22, SoldTickets = 11, ScreeningDate = new DateTime(2022, 1, 1, 0, 0, 0, 0), Duration = 90 }
        };
    }
}