namespace PrototypePattern
{
    class Rectangle : IFigure
    {
        readonly int _width;
        readonly int _height;

        public Rectangle(int w, int h) => (_width, _height) = (w, h);

        public object Clone() => new Rectangle(_width, _height);

        public void GetInfo() => Console.WriteLine($"矩形高度 {_height} 宽度 {_width}");
    }
}
