using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.Interpreter.CoreExtensions;
using Alexa.NET.SkillFlow.TextGenerator;
using Alexa.NET.SkillFlow.TextGenerator.CoreExtensions;
using NSubstitute.Exceptions;
using Xunit;

namespace Alexa.NET.SkillFlow.Tests
{
    public class FileExampleTests
    {
        [Fact]
        public async Task TestStoryGenerates()
        {
            var interpreter = new SkillFlowInterpreter();
            interpreter.AddCoreExtensions();
            Story story = null;
            using (var reader = File.OpenRead("Examples/story.abc"))
            {
                story = await interpreter.Interpret(reader);
            }

            var expected = File.ReadAllLines("Examples/story.abc");
            var actual = new string[] { };

            var mem = new MemoryStream();
            var context = new TextGeneratorContext(mem);
            var generator = new TextGenerator.TextGenerator();
            
            await generator.Generate(story, context);
            mem.Position = 0;

            using (var reader = new StreamReader(mem))
            {
                actual = reader.ReadToEnd().Split(context.LineEnding);
            }

            foreach (var set in expected.Zip(actual))
            {
                Assert.Equal(set.First.Trim(), set.Second.Trim());
            }
        }
    }
}
