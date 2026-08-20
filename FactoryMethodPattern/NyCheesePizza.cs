// 具体产品：纽约芝士披萨
public class NyCheesePizza : IPizza
{
    public string Name => "纽约芝士披萨";
    public void Prepare() => Console.WriteLine("准备纽约风味配料");
    public void Bake() => Console.WriteLine("烘烤 30 分钟");
    public void Cut() => Console.WriteLine("切成三角形");
    public void Box() => Console.WriteLine("装入蓝色盒子");
}
