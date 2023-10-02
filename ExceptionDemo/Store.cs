using LINQDemo.Data;

namespace ExceptionDemo;

public class Store
{
    public DataSource Db { get; set; } = new DataSource();

    public void Welcome()
    {
        Console.WriteLine("Välkommen!");

        ViewBasket();
    }

    private void ViewBasket()
    {
        var cart = Db.GetCartForPerson(10);

        foreach (var product in cart)
        {
            Console.WriteLine(product.Name);
        }
    }
}