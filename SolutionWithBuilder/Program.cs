using Common.Model;
using SolutionWithBuilder;

var userMicroService = new UserMicroServiceWithBuilder();

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});