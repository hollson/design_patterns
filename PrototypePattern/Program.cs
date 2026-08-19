// 原型模式（Prototype Pattern）
// 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。

IFigure figure = new Rectangle(30, 40);
IFigure clonedFigure = (IFigure)figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Circle(30);
clonedFigure = (IFigure)figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

Console.Read();
