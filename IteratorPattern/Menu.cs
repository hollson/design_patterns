namespace IteratorPattern;

/// <summary>
/// 菜单项，包含名称、描述、价格和是否为素食。
/// </summary>
public class Menu(string name, string description, double price, bool vegetarian)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public bool Vegetarian { get; } = vegetarian;
    public double Price { get; } = price;
}
