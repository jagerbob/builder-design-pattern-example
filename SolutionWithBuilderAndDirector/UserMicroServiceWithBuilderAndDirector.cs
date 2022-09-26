using Common.Bus;
using Common.Model;
using Common.Builder;

namespace SolutionWithBuilderAndDirector;

public class UserMicroServiceWithBuilderAndDirector
{
    private readonly Guid _microserviceId = Guid.NewGuid();
    private readonly Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
    private readonly FakeBusExchanger _busExchanger = new FakeBusExchanger();
    private readonly JSONEventMessageBuilder _messageBuilder = new JSONEventMessageBuilder();
    private readonly EventMessageDirector _messageDirector;


    public UserMicroServiceWithBuilderAndDirector()
    {
        _messageDirector = new EventMessageDirector(_messageBuilder);
        _messageDirector.BuildServiceStartupEvent();
        _busExchanger.Send(_messageBuilder.Build());
    }

    public void Shutdown()
    {
        _messageDirector.BuildServiceShutdownEvent();
        _busExchanger.Send(_messageBuilder.Build());
    }

    public void Add(User user)
    {
        _users.Add(user.Id, user);
        _messageBuilder.WithId(Guid.NewGuid());
        _messageBuilder.WithOrigin(_microserviceId);
        _messageBuilder.WithTimestamp(DateTime.Now);
        _messageBuilder.WithEventType("USER_CREATED");
        _messageBuilder.WithUserEvent(user.ToEvent());
        _busExchanger.Send(_messageBuilder.Build());
    }

    public void Remove(Guid userId)
    {
        _users.Remove(userId);
        _messageBuilder.WithId(Guid.NewGuid());
        _messageBuilder.WithOrigin(_microserviceId);
        _messageBuilder.WithTimestamp(DateTime.Now);
        _messageBuilder.WithEventType("USER_REMOVED");
        _messageBuilder.WithUserEvent(new () { UserId = userId });
        _busExchanger.Send(_messageBuilder.Build());
    }

    public void UpdateUserPassword(Guid userId, string newPassword)
    {
        _users[userId].Password = newPassword;
        _messageBuilder.WithId(Guid.NewGuid());
        _messageBuilder.WithOrigin(_microserviceId);
        _messageBuilder.WithTimestamp(DateTime.Now);
        _messageBuilder.WithEventType("USER_UPDATED");
        _messageBuilder.WithUserEvent(new () { Password = newPassword });
        _busExchanger.Send(_messageBuilder.Build());
    }
}
