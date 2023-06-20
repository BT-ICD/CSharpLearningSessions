/**
 * Learning References:
 * https://learn.microsoft.com/en-us/ef/core/querying/sql-queries
 * https://www.aspsnippets.com/Articles/Using-Stored-Procedure-in-Entity-Framework-Core-Database-First-Approach.aspx
 */


// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using slnEFCoreDatabaseFirst_StoreProcedure.Data;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
LearningDBDataContext learningDBDataContext = new LearningDBDataContext();

//To get list of products
//var products = learningDBDataContext.Products;
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}

//To get list of products - From Store Procedure
//var products = learningDBDataContext.Products.FromSql($"Product_GetAll").ToList();
////var products = learningDBDataContext.Products.FromSql($"Product_GetAll"); //Cannot access count when it returns IQueryable
//Console.WriteLine(products.Count); //Able to access when executed as a ToList 
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}

//To get a product by Id - From Store Procedure  with Parameter
var parameterId = new SqlParameter("@Id", 3);
var product = learningDBDataContext.Products.FromSql($"Product_GetByID {parameterId}").ToList().FirstOrDefault();
Console.WriteLine(product);