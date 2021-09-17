using JapTask1BackendCorrection.Entities;
using System.Collections.Generic;

namespace JapTask1BackendCorrection.Data.Seeders
{
    public class CategorySeed
    {
        public static List<Category> Categories { get; } = new()
        {
            new Category { Id = 1, Name = "ACTION" },
            new Category { Id = 2, Name = "COMEDY" },
            new Category { Id = 3, Name = "THRILLER" },
            new Category { Id = 4, Name = "DRAMA" },
            new Category { Id = 5, Name = "TRAGEDY" },
            new Category { Id = 6, Name = "CRIME" },
            new Category { Id = 7, Name = "BIOGRAPHY" },
            new Category { Id = 8, Name = "ADVENTURE" },
            new Category { Id = 9, Name = "WESTERN" },
            new Category { Id = 10, Name = "BIOGRAPHY" },
            new Category { Id = 11, Name = "ROMANCE" },
            new Category { Id = 12, Name = "SCI-FI" },
            new Category { Id = 13, Name = "DOCUMENTARY" },
            new Category { Id = 14, Name = "HISTORY" },
            new Category { Id = 15, Name = "ANIMATION" }
        };
    }
}
