// See https://aka.ms/new-console-template for more information

using ClassLib;
using LINQDemo.Data;

var db = new DataSource();

var cart = db.GetCartForPerson(10);

foreach (var product in cart)
{
    Console.WriteLine(product.Name);
}