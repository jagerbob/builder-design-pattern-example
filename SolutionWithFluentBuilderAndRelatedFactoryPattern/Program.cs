using Common.Model;
using SolutionWithFluentBuilderAndRelatedFactoryPattern;

var messageBuilder = FluentEventMessageBuilderFactory.Create("JSON");
var userMicroService = new UserMicroServiceWithFluentBuilderFactory(messageBuilder);

userMicroService.Add(new User
{
    Id = Guid.NewGuid(),
    Firstname = "Antoine",
    Lastname = "Houet"
});