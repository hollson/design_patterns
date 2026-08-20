// 具体产品：芝加哥蛤蜊披萨
public class ChicagoClamPizza : IPizza
{
    public string Name => "芝加哥蛤蜊披萨";
    public void Prepare() => Console.WriteLine("准备芝加哥风味配料");
    public void Bake() => Console.WriteLine("烘烤 45 分钟");
    public void Cut() => Console.WriteLine("切成方形");
    public void Box() => Console.WriteLine("装入红色盒子");
}
