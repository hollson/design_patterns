// 桥接模式（Bridge Pattern）
// 将抽象部分与实现部分分离，使它们可以独立变化。
// 通过组合关系代替继承关系，降低抽象和实现的耦合度。

using BridgePattern;

Console.WriteLine("\n========== 桥接模式 (Bridge Pattern) ==========");
Console.WriteLine("将抽象部分与实现部分分离，使它们可以独立变化\n");

IWeapon sword = new Sword(new FlyingEnchantment());
sword.Wield();
sword.Swing();
sword.Unwield();

IWeapon hammer = new Hammer(new SoulEatingEnchantment());
hammer.Wield();
hammer.Swing();
hammer.Unwield();
