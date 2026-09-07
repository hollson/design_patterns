namespace PrototypePattern;

class Circle : IFigure
{
    readonly int _radius;

    public Circle(int r) => _radius = r;

    // 克隆：不走构造函数，直接复制自身状态
    public object Clone() => new Circle(_radius);

    public void GetInfo() => Console.WriteLine($"半径为 {_radius} 的圆形");
}