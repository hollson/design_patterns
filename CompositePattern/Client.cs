namespace CompositePattern;

/// <summary>
/// 客户端类，通过菜单组件接口统一操作菜单结构。
/// </summary>
public class Client(MenuComponent menus)
{
    private readonly MenuComponent _menus = menus;

    public void Print() => _menus.Print();
}
