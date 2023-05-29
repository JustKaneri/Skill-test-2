
using Skill_tests_2.Models;
using System;

namespace Skill_tests_2.Data
{
    public class TempData
    {
        public static void CreateTmpData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetService<DataContext>();

            if (context.Points.Any())
            {
                return;
            }

            var Points = new List<Point>()
            {
                new Point()
                {
                    Xcoordinate = 100,
                    Ycoordinate = 100,
                    Radius = 20,
                    ColorHex = "#A9361E",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Comment 1",
                            BackColorHex = "#A76E62"
                        },
                        new Comment()
                        {
                            Content = "Comment 2",
                            BackColorHex = "6B362B"
                        }
                    }
                },
                new Point()
                {
                    Xcoordinate = 350,
                    Ycoordinate = 350,
                    Radius = 15,
                    ColorHex = "#A9361E",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Comment 2.1",
                            BackColorHex = "#A76E62"
                        },
                        new Comment()
                        {
                            Content = "Comment 2.2",
                            BackColorHex = "6B362B"
                        }
                    }
                }
            };

            context.Points.AddRange(Points);
            context.SaveChanges();
        }
    }
}
