namespace ProxyPattern;

/// <summary>
/// 代理图片类，实现延迟加载代理，仅在首次显示时才创建真实图片对象。
/// </summary>
public class ProxyImage : Image
{
    private RealImage? _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.display();
    }
}
