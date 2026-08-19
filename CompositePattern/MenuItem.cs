namespace CompositePattern;

/// <summary>
/// 菜单项，组合模式中的叶子节点。
/// </summary>
public class MenuItem(string name, string description, double price, bool isveg) : MenuComponent
{
    public override string Name { get; } = name;

    public override string Description { get; } = description;

    public override double Price { get; } = price;

    public override bool Vegetarian { get; } = isveg;

    public override void Print()
    {
        Console.WriteLine($"{Name} : {Price}  {(Vegetarian ? '+' : '*')} \n {Description}");
    }
}
