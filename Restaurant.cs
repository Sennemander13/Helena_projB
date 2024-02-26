using Newtonsoft.Json;

public static class Restaurant
{
    public static List<Meal> meals = new();


    public static void PopulateMenu()
    {
        StreamReader reader = new("Menu.Json");
        string File2Json = reader.ReadToEnd();
        meals = JsonConvert.DeserializeObject<List<Meal>>(File2Json)!;
        reader.Close();
    }

    static Restaurant()
    {
        PopulateMenu();
    }
    public static void AddToMenuJSON()
    {
        Console.Write("Add a Meal name: ");
        string mName = Console.ReadLine()!;
        Console.Write("Add a Meal price: ");
        double mPrice = Convert.ToDouble(Console.ReadLine()!);
        int amount = meals.Count;
        Meal new_meal = new(amount,mName,mPrice);
        meals.Add(new_meal);
        StreamWriter writer = new("Menu.Json");
        string List2Json = JsonConvert.SerializeObject(meals, Formatting.Indented);
        writer.Write(List2Json);
        writer.Close();
        Console.WriteLine($"added {new_meal.Info()}");
    }

    public static void ReadJson()
    {
        foreach (Meal meal in meals)
        {
            Console.WriteLine(meal.Info());
        }
        Console.WriteLine($"Meals on Menu: {meals.Count}");
    }


    public static void RemoveMeal(int index)
    {
        // Find the meal with the specified id
        Meal? mealToRemove = meals.FirstOrDefault(meal => meal.ID == index);

        if (mealToRemove != null)
        {
            meals.Remove(mealToRemove);
        }
        else
        {
            Console.WriteLine("No meal found with the specified id.");
        }

        StreamWriter writer = new("Menu.Json");
        string List2Json = JsonConvert.SerializeObject(meals, Formatting.Indented);
        writer.Write(List2Json);
        writer.Close();
        ReadJson();
    }
}