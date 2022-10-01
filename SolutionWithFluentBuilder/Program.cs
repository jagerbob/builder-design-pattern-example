using Common.Model;
using SolutionWithFluentBuilder;

var userMicroService = new UserMicroServiceWithFluentBuilder();

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});