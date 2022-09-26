using Common.Model;
using InitialIssue;

UserMicroServiceWithoutBuilder userMicroService = new UserMicroServiceWithoutBuilder();

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});