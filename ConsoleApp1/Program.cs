// See https://aka.ms/new-console-template for more information
using ProjectMomoDonation.Core.Models;

Console.WriteLine("Hello, World!");

Category a = new Category()
{
    CategoryId = 1,
    Name = "this is my name",
    UrlSlug = ""
};

Console.WriteLine(a.UrlSlug);