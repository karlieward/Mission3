namespace Mission3;

public class FoodItem
{
    public string name;
    public string category;
    public int quantity;
    public DateTime expirationDate;


    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        this.name = name;
        this.category = category;
        this.quantity = quantity;
        this.expirationDate = expirationDate;
    }
    
}

