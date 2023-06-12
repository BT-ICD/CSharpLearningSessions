// See https://aka.ms/new-console-template for more information
using EFCoreScaffoldDatabase.Data;

Console.WriteLine("Hello, World!");
LearningDbContext dbContext = new LearningDbContext();
var result = dbContext.Products.Where(p => p.Id == 2).FirstOrDefault();
Console.WriteLine(result.Id.ToString());
