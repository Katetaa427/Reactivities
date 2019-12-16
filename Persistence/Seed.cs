using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Visit a Museum",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "travel",
                        City = "London"
                    },
                    new Activity
                    {
                        Title = "Go on a Walking Tour",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Activity 1 months ago",
                        Category = "culture",
                        City = "Paris"
                    },
                    new Activity
                    {
                        Title = "Attend a Show",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Activity 1 months in future",
                        Category = "travel",
                        City = "Los Angeles"
                    },
                    new Activity
                    {
                        Title = "Food Tour",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Activity 2 months in future",
                        Category = "food",
                        City = "New York City"
                    },
                    new Activity
                    {
                        Title = "Go on a hike",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Activity 3 months in future",
                        Category = "travel",
                        City = "Chicgo"
                    }
 
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}