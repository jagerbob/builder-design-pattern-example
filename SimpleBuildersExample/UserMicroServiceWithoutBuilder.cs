using Common.Bus;
using Common.Model;

namespace InitialIssue;

public class UserMicroServiceWithoutBuilder
{
    private readonly Guid _microserviceId = Guid.NewGuid();
    private readonly Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
    private readonly FakeBusExchanger _busExchanger = new FakeBusExchanger();

    public void Add(User user)
    {
        _users.Add(user.Id, user);
        _busExchanger.Send(new XMLEventMessage(Guid.NewGuid(), null, _microserviceId, DateTime.Now, null, "userChannel", "USER_CREATED", user.ToEvent(), null));
    }

    public void Remove(Guid userId)
    {
        _users.Remove(userId);
        _busExchanger.Send(new XMLEventMessage(Guid.NewGuid(), null, _microserviceId, DateTime.Now, null, "userChannel", "USER_REMOVED", new () { UserId = userId }, null));
    }

    public void UpdateUserPassword(Guid userId, string newPassword)
    {
        _users[userId].Password = newPassword;
        _busExchanger.Send(new XMLEventMessage(Guid.NewGuid(), null, _microserviceId, DateTime.Now, null, "userChannel", "USER_UPDATED", new () { UserId = userId, Password = newPassword }, null));
    }
}
