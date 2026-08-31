// 原型模式（Prototype Pattern）
// 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。

using PrototypePattern;

Console.WriteLine("\n========== 原型模式 (Prototype Pattern) ==========");
Console.WriteLine("用原型实例指定创建对象的种类，并通过拷贝创建新对象\n");

IFigure figure = new Rectangle(30, 40);
IFigure clonedFigure = (IFigure)figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Circle(30);
clonedFigure = (IFigure)figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

Console.Read();
