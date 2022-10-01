namespace Common.Model;

public class XMLEventMessage : IEventMessage
{
    public Header Header { get; set; }

    public Body Body { get; set; }

    public XMLEventMessage()
    {
        Header = new Header();
        Body = new Body();
    }

    public XMLEventMessage(
        Guid id,
        Guid? correlationId,
        Guid origin,
        DateTime timestamp,
        Guid? authorId,
        string channel,
        string eventType,
        UserEvent userEvent,
        TransactionEvent transactionEvent)
    {
        Header = new()
        {
            Id = id,
            CorrelationId = correlationId,
            Origin = origin,
            Timestamp = timestamp,
            AuthorId = authorId,
        };
        Body = new()
        {
            Channel = channel,
            EventType = eventType,
            UserEvent = userEvent,
            TransactionEvent = transactionEvent
        };
    }
}

public class Header
{
    public Guid Id { get; set; }
    public Guid? CorrelationId { get; set; }
    public Guid Origin { get; set; }
    public DateTime Timestamp { get; set; }
    public Guid? AuthorId { get; set; }

    public Header() { }
}

public class Body
{
    public string Channel { get; set; }
    public string EventType { get; set; }
    public string Description { get; set; }
    public UserEvent UserEvent { get; set; }
    public TransactionEvent TransactionEvent { get; set; }

    public Body() { }
}

public class UserEvent
{
    public Guid UserId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Address { get; set; }

    public UserEvent() { }

    public UserEvent(
        Guid userId,
        string firstname,
        string lastname,
        string email,
        string password,
        DateTime? birthDate,
        string address)
    {
        UserId = userId;
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        Password = password;
        BirthDate = birthDate;
        Address = address;
    }
}

public class TransactionEvent
{
    public Guid TransactionId { get; set; }
    public string TransactionType { get; set; }
    public double amount { get; set; }

    public TransactionEvent() { }

    public TransactionEvent(Guid transactionId, string transactionType, double amount)
    {
        TransactionId = transactionId;
        TransactionType = transactionType;
        this.amount = amount;
    }
}
