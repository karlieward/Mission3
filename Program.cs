// Karlie Ward
// this is an inventory program that provides a menu allowing the user to add, delete, and print food items. It will also allow them to exit the program
// Required: min 2 classes

using Mission3;

// list of objects
List<FoodItem> inventory = new List<FoodItem>();

// keep the menu popping up unless they choose 4
bool keepRunning = true;

while (keepRunning)
{ 
// display menu    
Console.WriteLine("\n---- MENU ----");
Console.WriteLine("1. Add Food Items");
Console.WriteLine("2. Delete Food Items");
Console.WriteLine("3. Print List of Current Food Items");
Console.WriteLine("4. Exit Program");
Console.WriteLine("---------------");

Console.Write("What would you like to do? (1-4): ");

// get user choice and jump to corresponding option
string userChoice = Console.ReadLine();

if (userChoice == "1")
{
    Console.Write("\nEnter Food Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Item Category: ");
    string category = Console.ReadLine();

    Console.Write("Enter Quantity: ");
    string qtyInput = Console.ReadLine();

    int quantity; // error handle so quantity is an int and 0 or higher
    if (!int.TryParse(qtyInput, out quantity) || quantity < 0)
    {
        Console.WriteLine("Quantity must be a whole number.");
    }
    else
    {
        Console.Write("Enter Expiration Date (MM/DD/YYYY): ");
        string dateInput = Console.ReadLine();

        DateTime expirationDate; // error handle to make sure it is an acceptable date
        if (!DateTime.TryParse(dateInput, out expirationDate))
        {
            Console.WriteLine("Invalid date. Please use MM/DD/YYYY.");
        }
        else
        {
            // add all information and instantiate a new object and add it to inventory string
            FoodItem fi = new FoodItem(name, category, quantity, expirationDate);
            inventory.Add(fi);
            Console.WriteLine($"Added Food Item: {name}");
        }
    }
}
    else if (userChoice == "2")
    {
        if (inventory.Count > 0)
        {
            // loop through inventory to display with regular count instead of 0-based
            Console.WriteLine("\n---- CURRENT INVENTORY ----");
            for (int i = 0; i < inventory.Count; i++)
            {
                FoodItem foodItem = inventory[i];
                Console.WriteLine($" {i + 1}. {foodItem.name} ({foodItem.category}) qty: {foodItem.quantity} expires: {foodItem.expirationDate:MM/dd/yyyy}");
            }  
            Console.WriteLine("---------------------------");
            
            // get user info of which item to delete
            Console.Write("Enter the number of the item you want to delete: ");
            string deleteInput = Console.ReadLine();
            
            // convert the input to an integer and go back to 0-based
            int deleteNumber = int.Parse(deleteInput);
            int indexToDelete = deleteNumber - 1;
            
            //error handle to make sure they put in a number greater than 0 but less than the number in the inventory
            if (indexToDelete >= 0 && indexToDelete < inventory.Count)
            {
                //remove item and notify user
                FoodItem removedItem = inventory[indexToDelete];
                inventory.RemoveAt(indexToDelete);
                Console.WriteLine($"\nRemoved Food Item: {removedItem.name}");
            }
            else
            {
                // notify if number is not valid
                Console.WriteLine("That number is not in the list.");
            }
            
            
        }
        else
        {
            // notify if inventory.count is 0
            Console.WriteLine("\nThere are no items in inventory.");

        }
        
    }
    else if (userChoice == "3")
    {
        // display for no inventory
        if (inventory.Count == 0)
        {
            Console.WriteLine("\nThere are no items in inventory.");
        }
        else
        {
            // loop through inventory and display to user
            Console.WriteLine("\n---- CURRENT INVENTORY ----");
            foreach (FoodItem foodItem in inventory)
            {
                Console.WriteLine($"{foodItem.name} ({foodItem.category}) qty: {foodItem.quantity} expires: {foodItem.expirationDate:MM/dd/yyyy}");
            }  
            Console.WriteLine("---------------------------");
        }
        
    }
    else if (userChoice == "4")
    {
        // exit the program 
        Console.WriteLine("\nGoodbye");
        keepRunning = false;
    }

    // error handle if user enters something invalid
    else
    {Console.WriteLine("\nPlease enter 1, 2, 3, or 4");}
}
