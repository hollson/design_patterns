// 策略模式（Strategy Pattern）
// 定义一族算法，封装成独立类，运行时自由切换。

using StrategyPattern;

Console.WriteLine("\n========== 策略模式 (Strategy Pattern) ==========");
Console.WriteLine("定义一族算法，封装成独立类，运行时自由切换\n");

// 排序策略
Console.WriteLine("--- 排序策略 ---");
var sorter = new Sorter(new BubbleSort());
int[] arr1 = [3, 1, 4, 1, 5];
sorter.Sort(arr1);

sorter.SetStrategy(new QuickSort());
int[] arr2 = [9, 2, 6, 5, 3];
sorter.Sort(arr2);

sorter.SetStrategy(new MergeSort());
int[] arr3 = [7, 8, 0, 2, 4];
sorter.Sort(arr3);

// 支付方式
Console.WriteLine("\n--- 支付方式 ---");
var payment = new PaymentContext(new Alipay());
payment.Pay(100);

payment.SetStrategy(new WeChatPay());
payment.Pay(200);

payment.SetStrategy(new CreditCard());
payment.Pay(300);

// 路线规划
Console.WriteLine("\n--- 路线规划 ---");
var navigator = new Navigator(new Bicycle());
navigator.Navigate("公司", "地铁站", "1.5km");

navigator.SetStrategy(new HighSpeedRail());
navigator.Navigate("北京", "上海", "1318km");