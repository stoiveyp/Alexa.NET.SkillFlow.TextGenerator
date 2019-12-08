# Alexa.NET.SkillFlow.TextGenerator
A small library that generates text output based on SkillFlow Models

## Turning an object model into SkillFlow output
```csharp
var context = new TextGeneratorContext(writableStream);
var generator = new TextGenerator();
await generator.Generate(storyModel, context);
```

## Libraries

The model that is turned into SkillFlow story format is available at Alexa.NET.SkillFlow [GitHub](https://github.com/stoiveyp/Alexa.NET.SkillFlow) / [NuGet](https://www.nuget.org/packages/Alexa.NET.SkillFlow)

If you want to turn a story file back into an object model - you can use the SkillFlow interpreter Alexa.NET.SkillFlow.Interpreter [GitHub](https://github.com/stoiveyp/Alexa.NET.SkillFlow.Interpreter) / [NuGet](https://www.nuget.org/packages/Alexa.NET.SkillFlow.Interpreter)


