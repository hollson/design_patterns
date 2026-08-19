namespace ProxyPattern;

/// <summary>
/// 真实图片类，负责实际的磁盘加载和显示操作。
/// </summary>
public class RealImage : Image
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        loadFromDisk(_fileName);
    }

    public void display()
    {
        Console.WriteLine("Displaying " + _fileName);
    }

    private void loadFromDisk(string fileName)
    {
        Console.WriteLine("Loading " + fileName);
    }
}
