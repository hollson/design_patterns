namespace AdapterPattern;

/// <summary>旅行转换头（对象适配器）：组合被适配者，实现目标接口</summary>
public class TravelAdapter(BritishPlug plug) : IStdSocket
{
    public void PowerOn()
    {
        Console.WriteLine("[转换] 旅行转换头：外接国标插孔 → 内接英标三脚");
        plug.ThreePinConnect();      // 转调被适配者的原有接口
    }
}
