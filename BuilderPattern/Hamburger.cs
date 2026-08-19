namespace BuilderPattern;

/// <summary>
/// 汉堡类，包含尺寸、形状和配料等属性。
/// </summary>
public class Hamburger
{
    public int Size { get; set; }
    public string Shape { get; set; }
    public string[] Ingredients { get; set; }

    public override string ToString()
    {
        var hamburger = string.Join(" ", Ingredients);
        return $"Ingredients: {hamburger}, Size: {Size}, Shape: {Shape}";
    }
}
