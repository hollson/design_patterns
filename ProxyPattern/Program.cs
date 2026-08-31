// 代理模式（Proxy Pattern）：为目标对象提供一个代理以控制对它的访问，
// 代理对象与目标对象实现相同接口，可在访问目标前后添加额外逻辑（如延迟加载）。

using ProxyPattern;

Console.WriteLine("\n========== 代理模式 (Proxy Pattern) ==========");
Console.WriteLine("为其他对象提供代理以控制对这个对象的访问\n");

Image image = new ProxyImage("testImage.jpg");

// 图片将从磁盘加载
image.display();
Console.WriteLine("");

// 图片不会重复从磁盘加载
image.display();
