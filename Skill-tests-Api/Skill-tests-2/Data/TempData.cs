
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
                            BackColorHex = "#6B362B"
                        }
                    }
                },
                new Point()
                {
                    Xcoordinate = 350,
                    Ycoordinate = 350,
                    Radius = 15,
                    ColorHex = "#F11990",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Comment 2.1",
                            BackColorHex = "#A01E69"
                        },
                        new Comment()
                        {
                            Content = "Comment 2.2",
                            BackColorHex = "#6B362B"
                        }
                    }
                },
                new Point()
                {
                    Xcoordinate = 500,
                    Ycoordinate = 50,
                    Radius = 50,
                    ColorHex = "#2b2369",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Comment 3.1",
                            BackColorHex = "#665ac7"
                        },
                        new Comment()
                        {
                            Content = "Comment 3.2",
                            BackColorHex = "#d5d1eb"
                        },
                        new Comment()
                        {
                            Content = "Comment 3.3"
                        }
                    }
                }
            };

            context.Points.AddRange(Points);
            context.SaveChanges();
        }
    }
}
