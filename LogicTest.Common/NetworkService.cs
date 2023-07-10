namespace LogicTest.Common;

public class NetworkService : INetworkService
{
    private Network? _network;
    public void Connect(int source, int target)
    {
        _network?.Connect(source, target);
    }

    public void Init(int networkLength)
    {
        _network ??= new Network(networkLength);
    }

    public bool Query(int source, int target)
    {
        return _network?.Query(source, target) ?? false;
    }
}
