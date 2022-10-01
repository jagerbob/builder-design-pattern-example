using Common.Bus;
using Common.Model;
using Common.Builder;

namespace SolutionWithFluentBuilderAndRelatedFactoryPattern;

public class UserMicroServiceWithFluentBuilderFactory
{
    private readonly Guid _microserviceId = Guid.NewGuid();
    private readonly Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
    private readonly FakeBusExchanger _busExchanger = new FakeBusExchanger();
    private readonly FluentJSONEventMessageBuilder _fluentMessageBuilder = new FluentJSONEventMessageBuilder();

    public UserMicroServiceWithFluentBuilderFactory(IFluentEventMessageBuilder messageBuilder)
    {
        
    }

    public void Add(User user)
    {
        _users.Add(user.Id, user);
        _busExchanger.Send(_fluentMessageBuilder.WithId(Guid.NewGuid()).WithOrigin(_microserviceId).WithTimestamp(DateTime.Now).WithEventType("USER_CREATED").WithUserEvent(user.ToEvent()).Build());
    }

    public void Remove(Guid userId)
    {
        _users.Remove(userId);
        _busExchanger.Send(_fluentMessageBuilder.WithId(Guid.NewGuid()).WithOrigin(_microserviceId).WithTimestamp(DateTime.Now).WithEventType("USER_REMOVED").WithUserEvent(new() { UserId = userId }).Build());
    }

    public void UpdateUserPassword(Guid userId, string newPassword)
    {
        _users[userId].Password = newPassword;
        _busExchanger.Send(_fluentMessageBuilder.WithId(Guid.NewGuid()).WithOrigin(_microserviceId).WithTimestamp(DateTime.Now).WithEventType("USER_UPDATED").WithUserEvent(new() { Password = newPassword }).Build());
    }
}
