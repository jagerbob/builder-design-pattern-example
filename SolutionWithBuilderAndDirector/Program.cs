using Common.Model;
using SolutionWithBuilderAndDirector;

UserMicroServiceWithBuilderAndDirector userMicroService = new UserMicroServiceWithBuilderAndDirector();

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});

userMicroService.Shutdown();