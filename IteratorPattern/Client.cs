using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 客户端，通过迭代器遍历并打印菜单内容。
/// </summary>
public class Client
{
    private readonly IEnumerable _breakfast;
    private readonly IEnumerable _dinner;

    public Client(BreakfastMenu breakfast, DinnerMenu dinner)
    {
        _breakfast = breakfast.Items;
        _dinner = dinner.Items;
    }

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
            Console.WriteLine($"{i.Name}  Rs. {i.Price} {(i.Vegetarian ? "*" : "x")} \n {i.Description} ");
        }
    }
}
