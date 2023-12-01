using ChatRoomMediatorPattern.Interfaces;

namespace ChatRoomMediatorPattern.Component;

public class UserComponent : BaseComponent
{
    public UserComponent(string name, IMediator mediator)
    {
        Name = name;
        
        this.SetMediator(mediator);
    }

    public override void ReceiveMessage(string message, string sender)
    {
        throw new NotImplementedException();
    }

    public override void SendMessage(string message, string receiver)
    {
        _mediator.Notify(Name, message, receiver);
    }
}