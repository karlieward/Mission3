namespace Mission3;

public class FoodItem // food item class with public variables to be used in program.cs
{
    public string name;
    public string category;
    public int quantity;
    public DateTime expirationDate;


    // constructor which happens regardless, is named same as class, and has no return
    // this is the item we are on and is assigning it to variable
    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        this.name = name;
        this.category = category;
        this.quantity = quantity;
        this.expirationDate = expirationDate;
    }
    
}

