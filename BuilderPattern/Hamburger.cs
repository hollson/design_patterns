using System.Diagnostics.CodeAnalysis;

namespace BuilderPattern;

/// <summary>
/// 汉堡类，包含尺寸、形状和配料等属性。
/// </summary>
public class Hamburger
{
    [SetsRequiredMembers]
    public Hamburger() { }

    public int Size { get; set; }
    public required string Shape { get; set; } = string.Empty;
    public required string[] Ingredients { get; set; } = [];

    public override string ToString()
    {
        var hamburger = string.Join(" ", Ingredients);
        return $"Ingredients: {hamburger}, Size: {Size}, Shape: {Shape}";
    }
}
