using ClassLib;
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
        try
        {
            var cart = Db.GetCartForPerson(10);

            foreach (var product in cart)
            {
                Console.WriteLine(product.Name);
            }
        }
        catch (CartIndexException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Ajajaj.");
        }
        finally
        {
            Console.WriteLine("All is reset.");
        }
    }
}