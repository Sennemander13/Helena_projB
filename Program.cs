using Newtonsoft.Json;
public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                   Admin                    Server");
            string choice = Console.ReadLine()!.ToLower();
            if (choice == "a" || choice == "admin")
            {
                Admin();
            }
            else if (choice == "s" || choice == "server")
            {
                Server();
            }
            else{
                continue;
            }
        }
    }



    public static void Admin()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Read: Read Menu\nAdd: Add to Menu\nRemove: Remove from Menu");
            string choice = Console.ReadLine()!.ToLower();
            if (choice == "r" || choice == "read")
            {
                Restaurant.ReadJson();
            }
            else if (choice == "a" || choice == "add")
            {
                Restaurant.AddToMenuJSON();
            }
            else if (choice == "re" || choice == "remove")
            {
                Restaurant.ReadJson();
                Console.Write("Wich Meal do you want to remove (index): ");
                int number = Convert.ToInt32(Console.ReadLine()!);
                Restaurant.RemoveMeal(number);
            }
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
    public static void Server()
    {

    }
}