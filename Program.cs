using Mission3;

List<FoodItem> inventory = new List<FoodItem>();

bool keepRunning = true;

while (keepRunning)
{    
Console.WriteLine("\n---- MENU ----");
Console.WriteLine("1. Add Food Items");
Console.WriteLine("2. Delete Food Items");
Console.WriteLine("3. Print List of Current Food Items");
Console.WriteLine("4. Exit Program");
Console.WriteLine("---------------");

Console.Write("What would you like to do? (1-4): ");


string userChoice = Console.ReadLine();

    if (userChoice == "1")
    {
        Console.Write("Enter Food Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter Item Category: ");
        string category = Console.ReadLine();
        
        Console.Write("Enter Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Expiration Date (MM/DD/YYYY): ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());
        
        FoodItem fi = new FoodItem(name, category, quantity, expirationDate);
        inventory.Add(fi);
        Console.WriteLine($"Added Food Item: {name}");
        
    }
    else if (userChoice == "2")
    {
        if (inventory.Count > 0)
        {
            inventory.RemoveAt(0);
            Console.WriteLine("\nFirst Item Removed");
        }
        else
        {
            Console.WriteLine("\nThere are no items in inventory");

        }
        
    }
    else if (userChoice == "3")
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("\nThere are no items in inventory");
        }
        else
        {
            Console.WriteLine("---- CURRENT INVENTORY ----");
            foreach (FoodItem foodItem in inventory)
            {
                Console.WriteLine($"{foodItem.name} ({foodItem.category}) qty: {foodItem.quantity} expires: {foodItem.expirationDate:MM/dd/yyyy}");
            }  
            Console.WriteLine("-------------------------");
        }
        
    }
    else if (userChoice == "4")
    {
        Console.WriteLine("\nGoodbye");
        keepRunning = false;
    }
    else
    {Console.WriteLine("\nPlease enter 1, 2, 3, or 4");}
}
