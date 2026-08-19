// 单例模式 (Singleton Pattern)
// 确保一个类只有一个实例，并提供一个全局访问点。
// 这里巧克力锅炉(ChocolateBoiler)使用延迟初始化(Lazy<T>)保证全局唯一实例，
// 避免同时存在多个锅炉导致资源浪费或状态不一致。

using SingletonPattern;

try
{
    var chocoEggs = ChocolateBoiler.GetInstance();
    chocoEggs.Fill();
    chocoEggs.Boil();
    chocoEggs.Drain();
}
catch (Exception)
{
    Console.Write("Oops");
}
