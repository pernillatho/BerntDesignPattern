using ChatRoomMediatorPattern.Component;
using ChatRoomMediatorPattern.Interfaces;

namespace ChatRoomMediatorPattern.Concrete;

public class ConcreteMediator : IMediator
{
    private readonly Dictionary<BaseComponent, string> _users = new ();

    public void Notify(string sender, string receiver, string message)
    {
       
    }

    public void Register(BaseComponent user)
    {
       _users.Add(user, user.Name);
    }
}