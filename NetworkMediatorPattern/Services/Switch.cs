using NetworkMediatorPattern.Interfaces;

namespace NetworkMediatorPattern.Services;

public class Switch : ISwitch
{
    private readonly Dictionary<string, IComputer> _computers = new ();

    public void Notify(string message, string receiver, string sender)
    {
        _computers[receiver].ReceivedMessage(sender, message);
    }

    public void NotifyAll(string message, string sender)
    {
        
    }

    public void Register(IComputer iComputer)
    {
        _computers.Add(iComputer.Name, iComputer);
    }
}