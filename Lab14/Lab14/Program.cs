internal class Program
{
    static void Main(string[] args)
    {
        Product product = new Product
        {
            Id = 1,
            Brend="Zara",
            Model="Shalvar",
            Price=50,
            Cost=26,
            Income=24,
            Count=1
            
        };
        product.checkIncome();
    }
}
public class Product
{
    public int Id;
    public string Brend;
    public string Model;
    public int Price;
    public int Cost;
    public int Income;
    public int Count;
    public Product(int id, string brend, string model,int price,int cost,int income,int count)
    {
        Id = id;
        Brend = brend;
        Model = model;
        Price = price;
        Cost = cost;
        Income = income;
        Count = count;
    }
    public Product()
    {
        
    }
    public void checkIncome()
    {
        if (Income<0)
        {
            Income = 0;
        }
        else
        {
            Console.WriteLine($"{Income} gelir");
        }
    }
}
