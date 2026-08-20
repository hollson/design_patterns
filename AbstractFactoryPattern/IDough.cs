// 抽象产品：面团
public interface IDough
{
    string Name { get; }
}

// 具体产品
public class ThinCrust : IDough
{
    public string Name => "薄面团";
}

public class DeepDish : IDough
{
    public string Name => "深盘面团";
}
