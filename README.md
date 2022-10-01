# ⚒️ Builder pattern example ⚒️ 

This project was created to explain how the Builder Pattern and its variants are implemented. For that, we took the example of a microservice
that would send messages over a communication bus. For the purpose of this demo project, the communication bus will send it's data in this folder:

```sh
C:\Users\current_user\Documents\BuilderPatternFakeBus
```

> Note: your OS may block the creation of files in this folder, if it's the case, just allow the blocked application through Windows Security 

Depending of the variable you configured in the playground, the bus may generate .json or .xml files

## Projects
- **Common** : contains the model, the fake bus, and the builders that will be used in the other projects
- **InitialIssue** : demonstrates the original problem that the builder pattern is solving
- **SolutionWithBuilder** : Shows an example of implementation of a basic builder pattern
- **SolutionWithBuilderAndDirector** : This projects goes a little further by demonstrating how to implement a director on top of a builder
- **SolutionWithFluentBuilder** : Shows how to implement the fluent builder, an evolution of the basic builder implementation
- **SolutionWithFluentBuilderAndRelatedFactoryPattern** : Shows how the factory design pattern is related to the builder design pattern.


