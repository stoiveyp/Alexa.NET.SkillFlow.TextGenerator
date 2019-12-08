using System.Threading.Tasks;
using Alexa.NET.SkillFlow.CoreExtensions;
using Alexa.NET.SkillFlow.Generator;

namespace Alexa.NET.SkillFlow.TextGenerator.CoreExtensions
{
    public class TimeGenerator : IComponentGenerator<TextGeneratorContext>
    {
        public async Task<TextGeneratorContext> Generate(SkillFlowComponent component, TextGeneratorContext context)
        {
            if (component is Time)
            {
                await context.WriteLine("time");
            }

            return context;
        }
    }
}