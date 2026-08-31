﻿﻿namespace BuilderPattern;

/// <summary>
/// 妻子的汉堡建造者，构建一个较小的长方形汉堡。
/// </summary>
public class WifesHamburgerBuilder : IBuilder
{
    private Hamburger _hamburger = null!;

    public void AddIngredients() => _hamburger.Ingredients = ["面包", "沙拉"];

    public void AddShape() => _hamburger.Shape = "长方体";

    public void AddSize() => _hamburger.Size = 6; //inches

    public void Reset() => _hamburger = new Hamburger();

    public Hamburger Build() => _hamburger;
}
