// 访问者模式：不改变元素类的前提下，为一组元素定义新操作（双重分派）

using VisitorPattern;

Console.WriteLine("========== 访问者模式 (Visitor Pattern) ==========");
Console.WriteLine("不改动元素类，为对象结构新增操作\n");

Console.WriteLine("--- 经典场景: 购物车计税与折扣 ---");
Console.WriteLine(">> 同一批商品，跑两种访问者（算税 / 算折扣）：\n");

Item[] cart =
[
    new Book("设计模式：可复用面向对象软件的基础", 89.00m),
    new Food("有机菠菜 500g", 12.50m),
    new Electronics("机械键盘", 499.00m),
];

var tax = new TaxVisitor();
Console.WriteLine(">> 第一种操作：税费计算访问者");
foreach (var item in cart)
    item.Accept(tax);                       // 双分派：元素类型 × 访问者类型
Console.WriteLine($"[合计] 税费总计 ¥{tax.TotalTax:0.00}\n");

var discount = new DiscountVisitor();
Console.WriteLine(">> 第二种操作：会员折扣访问者（商品类零改动）");
foreach (var item in cart)
    item.Accept(discount);
Console.WriteLine($"[合计] 折后应付 ¥{discount.TotalPayable:0.00}");

Console.WriteLine("\n--- 软件项目: 文档多格式导出 ---");
Console.WriteLine(">> 同一份文档，导出两种格式：\n");

DocElement[] document =
[
    new Heading("访问者模式"),
    new Paragraph("在不改变元素类的前提下定义新操作。"),
    new CodeBlock("item.Accept(visitor);"),
];

Console.WriteLine(">> Markdown 导出器：");
foreach (var element in document)
    element.Accept(new MarkdownExporter());

Console.WriteLine("\n>> HTML 导出器（新增格式只加一个类）：");
foreach (var element in document)
    element.Accept(new HtmlExporter());
