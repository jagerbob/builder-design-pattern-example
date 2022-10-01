using Common.Model;

namespace Common.Builder;

public class XMLEventMessageBuilder : IEventMessageBuilder
{
    private XMLEventMessage _message;

    public XMLEventMessageBuilder() => Reset();

    public void WithAuthor(Guid authorId) => _message.Header.AuthorId = authorId;

    public void WithChannel(string channel) => _message.Body.Channel = channel;

    public void WithEventType(string eventType) => _message.Body.EventType = eventType;

    public void WithId(Guid id) => _message.Header.Id = id;

    public void WithCorrelationId(Guid correlationId) => _message.Header.CorrelationId = correlationId;

    public void WithOrigin(Guid origin) => _message.Header.Origin = origin;

    public void WithTimestamp(DateTime timestamp) => _message.Header.Timestamp = timestamp;

    public void WithTransactionEvent(TransactionEvent transactionEvent) => _message.Body.TransactionEvent = transactionEvent;

    public void WithUserEvent(UserEvent userEvent) => _message.Body.UserEvent = userEvent;

    public void Reset() => _message = new XMLEventMessage();

    public XMLEventMessage Build()
    {
        var message = _message;
        Reset();
        return message;
    }
}
