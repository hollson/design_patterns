namespace MediatorPattern;

/// <summary>控制塔（具体中介者）：掌握跑道状态，统一协调起降</summary>
public class ControlTower : ITowerMediator
{
    private readonly List<Aircraft> _airspace = [];         // 管辖空域内的飞机
    private string? _runwayUser;                            // 跑道占用者

    public void Register(Aircraft aircraft)
    {
        _airspace.Add(aircraft);
        aircraft.RegisterTower(this);
        Console.WriteLine($"[塔台] {aircraft.CallSign} 进入管辖空域");
    }

    public void CoordinateLanding(Aircraft requester)
    {
        if (_runwayUser is null)
        {
            _runwayUser = requester.CallSign;
            requester.Receive($"允许降落，跑道已清空");
        }
        else
        {
            requester.Receive($"跑道正被 {_runwayUser} 占用，请盘旋等待");
        }
    }

    public void CoordinateTakeoff(Aircraft requester)
    {
        if (_runwayUser is null)
        {
            _runwayUser = requester.CallSign;
            requester.Receive("允许起飞，注意爬升高度");
        }
        else
        {
            requester.Receive($"跑道正被 {_runwayUser} 占用，请在停机坪等待");
        }
    }

    /// <summary>模拟占用方脱离跑道（释放资源）</summary>
    public void ReleaseRunway(Aircraft aircraft)
    {
        if (_runwayUser == aircraft.CallSign)
        {
            _runwayUser = null;
            Console.WriteLine($"[塔台] {aircraft.CallSign} 已脱离跑道");
        }
    }
}
