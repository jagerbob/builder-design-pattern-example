using Common.Model;

namespace Common.Builder;

public interface IFluentEventMessageBuilder<T>
{
    IFluentEventMessageBuilder<T> WithId(Guid id);
    IFluentEventMessageBuilder<T> WithCorrelationId(Guid correlationId);
    IFluentEventMessageBuilder<T> WithOrigin(Guid origin);
    IFluentEventMessageBuilder<T> WithTimestamp(DateTime timestamp);
    IFluentEventMessageBuilder<T> WithAuthor(Guid authorId);
    IFluentEventMessageBuilder<T> WithChannel(string channel);
    IFluentEventMessageBuilder<T> WithEventType(string eventType);
    IFluentEventMessageBuilder<T> WithUserEvent(UserEvent userEvent);
    IFluentEventMessageBuilder<T> WithTransactionEvent(TransactionEvent transactionEvent);
    T Build();
    void Reset();
}
