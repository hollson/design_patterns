using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 客户端，通过迭代器遍历并打印菜单内容。
/// </summary>
public class Client(BreakfastMenu breakfast, DinnerMenu dinner)
{
    private readonly IEnumerable _breakfast = breakfast.Items;
    private readonly IEnumerable _dinner = dinner.Items;

    public void PrintMenu()
    {
        PrintMenu(_breakfast);
        PrintMenu(_dinner);
    }

    private void PrintMenu(IEnumerable iter)
    {
        foreach (var item in iter)
        {
            var i = (Menu)item;
            Console.WriteLine($"{i.Name}  ￥{i.Price} {(i.Vegetarian ? "*" : "x")} \n {i.Description} ");
        }
    }
}
