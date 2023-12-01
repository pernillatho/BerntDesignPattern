using Common;
using NetworkMediatorPattern.Interfaces;

namespace NetworkMediatorPattern.Computer;

public class Computer : IComputer
{
    public string Name { get; init; }

    protected ISwitch _switch;
    protected ILogger _logger;

    public Computer(string name, ILogger logger, ISwitch sswitch)
    {
        Name = name;
        _switch = sswitch;
        _logger = logger;

        _switch.Register(this);
    }

    public void SendingMessage(string receiver, string message)
    {
        _switch.Notify(message, receiver, Name);
    }

    public void ReceivedMessage(string sender, string message)
    {
        _logger.Log($"{Name} received a message {message} from {sender}");
    }

    public void BroadCastMessage(string message)
    {
        _switch.NotifyAll(message, Name);
    }
}