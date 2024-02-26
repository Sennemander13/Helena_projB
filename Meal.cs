public class Meal
{
    public int ID;
    public string Name;
    public double Price;
    // public int 
    public Meal(int id, string name, double price)
    {
        ID = id;
        Name = name;
        Price = price;
    }

    public string Info()
    {
        return $"{ID}|{Name}, Price: {Price}";
    }
}