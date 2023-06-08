// See https://aka.ms/new-console-template for more information
using EFCoreEntityFirst.Data;
using EFCoreEntityFirst.Models;

Console.WriteLine("Hello, World!");

//using (var context = new ProductDataContext())
//{
//    var product = new Product() { Name = "Dettol", Rate = 30 };
//    context.Products.Add(product);
//    context.SaveChanges();
//}

//Edit
//using var db= new ProductDataContext();
//var p = db.Products.Where(x => x.Id == 1).FirstOrDefault();
//p.Rate = 1010;
//db.SaveChanges();
//Console.WriteLine("Updated");

//Delete
using var db = new ProductDataContext();
var p = db.Products.Where(x => x.Id == 1).FirstOrDefault();
db.Remove(p);
db.SaveChanges();
Console.WriteLine("Deleted");





