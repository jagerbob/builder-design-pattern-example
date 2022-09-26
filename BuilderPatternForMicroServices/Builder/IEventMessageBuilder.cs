using Common.Model;

namespace Common.Builder;

public interface IEventMessageBuilder
{
    void WithId(Guid id);
    void WithCorrelationId(Guid correlationId);
    void WithOrigin(Guid origin);
    void WithTimestamp(DateTime timestamp);
    void WithAuthor(Guid authorId);
    void WithChannel(string channel);
    void WithEventType(string eventType);
    void WithUserEvent(UserEvent userEvent);
    void WithTransactionEvent(TransactionEvent transactionEvent);
    void Reset();
}
