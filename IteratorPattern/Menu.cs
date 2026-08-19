namespace IteratorPattern;

/// <summary>
/// 菜单项，包含名称、描述、价格和是否为素食。
/// </summary>
public class Menu
{
    public string Name { get; }
    public string Description { get; }
    public bool Vegetarian { get; }
    public double Price { get; }

    public Menu(string name, string description, double price, bool vegetarian)
    {
        Name = name;
        Description = description;
        Price = price;
        Vegetarian = vegetarian;
    }
}
