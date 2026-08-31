﻿// 适配器模式 (Adapter Pattern)
// 将一个类的接口转换成客户希望的另一个接口，使得原本不兼容的类可以一起工作。
// 这里将火鸡(Turkey)通过适配器(TurkeyAdapter)转换为鸭子(Duck)的接口。

using AdapterPattern;

Console.WriteLine("\n========== 适配器模式 (Adapter Pattern) ==========");
Console.WriteLine("将一个类的接口转换成客户期望的另一个接口，使不兼容的类可协同工作\n");

var turkey = new WildTurkey();
var adapter = new TurkeyAdapter(turkey);
Tester(adapter);

static void Tester(IDuck duck)
{
    duck.Fly();
    duck.Quack();
}
