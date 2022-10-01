namespace Common.Model;

public class User
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
}

public static class UserExtensions
{
    public static UserEvent ToEvent(this User user) => new UserEvent
    {
        UserId = user.Id,
        Firstname = user.Firstname,
        Lastname = user.Lastname,
        Email = user.Email,
        Password = user.Password,
        BirthDate = user.BirthDate,
        Address = user.Address
    };
}