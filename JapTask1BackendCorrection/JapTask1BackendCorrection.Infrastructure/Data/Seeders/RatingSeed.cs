﻿using JapTask1BackendCorrection.Core.Entities;
using System.Collections.Generic;

namespace JapTask1BackendCorrection.Data.Seeders
{
    public class RatingSeed
    {
        public static List<Rating> Ratings { get; } = new()
        {
            //show ratings
            new Rating { Id = 1, Value = 4.6F, MediaId = 1, UserId = 1 },
            new Rating { Id = 2, Value = 4.5F, MediaId = 2, UserId = 1 },
            new Rating { Id = 3, Value = 4.5F, MediaId = 3, UserId = 1 },
            new Rating { Id = 4, Value = 4.5F, MediaId = 4, UserId = 1 },
            new Rating { Id = 5, Value = 4.4F, MediaId = 5, UserId = 1 },
            new Rating { Id = 6, Value = 4.35F, MediaId = 6, UserId = 1 },
            new Rating { Id = 7, Value = 4.3F, MediaId = 7, UserId = 1 },
            new Rating { Id = 8, Value = 4.2F, MediaId = 8, UserId = 1 },
            new Rating { Id = 9, Value = 4.2F, MediaId = 9, UserId = 1 },
            new Rating { Id = 10, Value = 4.2F, MediaId = 10, UserId = 1 },
            new Rating { Id = 11, Value = 4.2F, MediaId = 11, UserId = 1 },
            new Rating { Id = 12, Value = 4.1F, MediaId = 12, UserId = 1 },
            new Rating { Id = 13, Value = 4.1F, MediaId = 13, UserId = 1 },
            //movie ratings
            new Rating { Id = 14, Value = 4.7F, MediaId = 14, UserId = 1 },
            new Rating { Id = 15, Value = 4.6F, MediaId = 15, UserId = 1 },
            new Rating { Id = 16, Value = 4.6F, MediaId = 16, UserId = 1 },
            new Rating { Id = 17, Value = 4.6F, MediaId = 17, UserId = 1 },
            new Rating { Id = 18, Value = 4.5F, MediaId = 18, UserId = 1 },
            new Rating { Id = 19, Value = 4.4F, MediaId = 19, UserId = 1 },
            new Rating { Id = 20, Value = 4.3F, MediaId = 20, UserId = 1 },
            new Rating { Id = 21, Value = 4.2F, MediaId = 21, UserId = 1 },
            new Rating { Id = 22, Value = 4.1F, MediaId = 22, UserId = 1 },
            new Rating { Id = 23, Value = 4.1F, MediaId = 23, UserId = 1 },
            new Rating { Id = 24, Value = 4.1F, MediaId = 24, UserId = 1 },
            new Rating { Id = 25, Value = 4F, MediaId = 25, UserId = 1 },
            new Rating { Id = 26, Value = 3.9F, MediaId = 26, UserId = 1 },
            //
            new Rating { Id = 27, Value = 4.7F, MediaId = 27, UserId = 1 },
            new Rating { Id = 28, Value = 4.6F, MediaId = 28, UserId = 1 },
            new Rating { Id = 29, Value = 4.6F, MediaId = 29, UserId = 1 },
            new Rating { Id = 30, Value = 4.6F, MediaId = 30, UserId = 1 },
            new Rating { Id = 31, Value = 4.5F, MediaId = 31, UserId = 1 },
            new Rating { Id = 32, Value = 4.4F, MediaId = 32, UserId = 1 },
            new Rating { Id = 33, Value = 4.3F, MediaId = 33, UserId = 1 },
            new Rating { Id = 34, Value = 4.2F, MediaId = 34, UserId = 1 },
            new Rating { Id = 35, Value = 4.1F, MediaId = 35, UserId = 1 },
            new Rating { Id = 36, Value = 4.1F, MediaId = 36, UserId = 1 },
            new Rating { Id = 37, Value = 4.1F, MediaId = 37, UserId = 1 },
            new Rating { Id = 38, Value = 4F, MediaId = 38, UserId = 1 },
            new Rating { Id = 39, Value = 3.9F, MediaId = 39, UserId = 1 },
            //
            new Rating { Id = 40, Value = 4.7F, MediaId = 40, UserId = 1 },
            new Rating { Id = 41, Value = 4.6F, MediaId = 41, UserId = 1 },
            new Rating { Id = 42, Value = 4.6F, MediaId = 42, UserId = 1 },
            new Rating { Id = 43, Value = 4.6F, MediaId = 43, UserId = 1 },
            new Rating { Id = 44, Value = 4.5F, MediaId = 44, UserId = 1 },
            new Rating { Id = 45, Value = 4.4F, MediaId = 45, UserId = 1 },
            new Rating { Id = 46, Value = 4.3F, MediaId = 46, UserId = 1 },
            new Rating { Id = 47, Value = 4.2F, MediaId = 47, UserId = 1 },
            new Rating { Id = 48, Value = 4.1F, MediaId = 48, UserId = 1 },
            new Rating { Id = 49, Value = 4.1F, MediaId = 49, UserId = 1 },
            new Rating { Id = 50, Value = 4.1F, MediaId = 50, UserId = 1 },
            new Rating { Id = 51, Value = 4F, MediaId = 51, UserId = 1 },
            new Rating { Id = 52, Value = 3.9F, MediaId = 52, UserId = 1 },
            //
            new Rating { Id = 53, Value = 4.7F, MediaId = 53, UserId = 1 },
            new Rating { Id = 54, Value = 4.6F, MediaId = 54, UserId = 1 },
            new Rating { Id = 55, Value = 4.6F, MediaId = 55, UserId = 1 },
            new Rating { Id = 56, Value = 4.6F, MediaId = 56, UserId = 1 },
            new Rating { Id = 57, Value = 4.5F, MediaId = 57, UserId = 1 },
            new Rating { Id = 58, Value = 4.4F, MediaId = 58, UserId = 1 },
            new Rating { Id = 59, Value = 4.3F, MediaId = 59, UserId = 1 },
            new Rating { Id = 60, Value = 4.2F, MediaId = 60, UserId = 1 },
            new Rating { Id = 61, Value = 4.1F, MediaId = 61, UserId = 1 },
            new Rating { Id = 62, Value = 4.1F, MediaId = 62, UserId = 1 },
            new Rating { Id = 63, Value = 4.1F, MediaId = 63, UserId = 1 },
            new Rating { Id = 64, Value = 4F, MediaId = 64, UserId = 1 },
            new Rating { Id = 65, Value = 3.9F, MediaId = 65, UserId = 1 },
            //
            new Rating { Id = 66, Value = 4.7F, MediaId = 66, UserId = 1 },
            new Rating { Id = 67, Value = 4.6F, MediaId = 67, UserId = 1 },
            new Rating { Id = 68, Value = 4.6F, MediaId = 68, UserId = 1 },
            new Rating { Id = 69, Value = 4.6F, MediaId = 69, UserId = 1 },
            new Rating { Id = 70, Value = 4.5F, MediaId = 70, UserId = 1 },
            new Rating { Id = 71, Value = 4.4F, MediaId = 71, UserId = 1 },
            new Rating { Id = 72, Value = 4.3F, MediaId = 72, UserId = 1 },
            new Rating { Id = 73, Value = 4.2F, MediaId = 73, UserId = 1 },
            new Rating { Id = 74, Value = 4.1F, MediaId = 74, UserId = 1 },
            new Rating { Id = 75, Value = 4.1F, MediaId = 75, UserId = 1 },
            new Rating { Id = 76, Value = 4.1F, MediaId = 76, UserId = 1 },
            new Rating { Id = 77, Value = 4F, MediaId = 77, UserId = 1 },
            new Rating { Id = 78, Value = 3.9F, MediaId = 78, UserId = 1 },
            //
            new Rating { Id = 79, Value = 4.7F, MediaId = 79, UserId = 1 },
            new Rating { Id = 80, Value = 4.6F, MediaId = 80, UserId = 1 },
            new Rating { Id = 81, Value = 4.6F, MediaId = 81, UserId = 1 },
            new Rating { Id = 82, Value = 4.6F, MediaId = 82, UserId = 1 },
            new Rating { Id = 83, Value = 4.5F, MediaId = 83, UserId = 1 },
            new Rating { Id = 84, Value = 4.4F, MediaId = 84, UserId = 1 },
            new Rating { Id = 85, Value = 4.3F, MediaId = 85, UserId = 1 },
            new Rating { Id = 86, Value = 4.2F, MediaId = 86, UserId = 1 },
            new Rating { Id = 87, Value = 4.1F, MediaId = 87, UserId = 1 },
            new Rating { Id = 88, Value = 4.1F, MediaId = 88, UserId = 1 },
            new Rating { Id = 89, Value = 4.1F, MediaId = 89, UserId = 1 },
            new Rating { Id = 90, Value = 4F, MediaId = 90, UserId = 1 },
            new Rating { Id = 91, Value = 3.9F, MediaId = 91, UserId = 1 },
            //
            new Rating { Id = 92, Value = 4.7F, MediaId = 92, UserId = 1 },
            new Rating { Id = 93, Value = 4.6F, MediaId = 93, UserId = 1 },
            new Rating { Id = 94, Value = 4.6F, MediaId = 94, UserId = 1 },
            new Rating { Id = 95, Value = 4.6F, MediaId = 95, UserId = 1 },
            new Rating { Id = 96, Value = 4.5F, MediaId = 96, UserId = 1 },
            new Rating { Id = 97, Value = 4.4F, MediaId = 97, UserId = 1 },
            new Rating { Id = 98, Value = 4.3F, MediaId = 98, UserId = 1 },
            new Rating { Id = 99, Value = 4.2F, MediaId = 99, UserId = 1 },
            new Rating { Id = 100, Value = 4.1F, MediaId = 100, UserId = 1 },
            //   
            new Rating { Id = 101, Value = 5F, MediaId = 100, UserId = 1 },
            new Rating { Id = 102, Value = 5F, MediaId = 100, UserId = 1 },
            new Rating { Id = 103, Value = 5F, MediaId = 100, UserId = 1 },
            //
            new Rating { Id = 104, Value = 5F, MediaId = 10, UserId = 1 },
            new Rating { Id = 105, Value = 5F, MediaId = 67, UserId = 1 },
            new Rating { Id = 106, Value = 5F, MediaId = 67, UserId = 1 },
            new Rating { Id = 107, Value = 5F, MediaId = 44, UserId = 1 },
            new Rating { Id = 108, Value = 5F, MediaId = 17, UserId = 1 },
            new Rating { Id = 109, Value = 5F, MediaId = 17, UserId = 1 },
            //
            new Rating { Id = 110, Value = 5F, MediaId = 7, UserId = 1 }
        };
    }
}