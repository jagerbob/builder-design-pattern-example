using Common.Model;
using SolutionWithBuilder;

UserMicroServiceWithBuilder userMicroService = new UserMicroServiceWithBuilder();

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});