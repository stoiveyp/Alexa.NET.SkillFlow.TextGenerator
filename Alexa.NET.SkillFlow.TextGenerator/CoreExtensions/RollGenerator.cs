using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.SkillFlow.CoreExtensions;
using Alexa.NET.SkillFlow.Generator;

namespace Alexa.NET.SkillFlow.TextGenerator.CoreExtensions
{
    class RollGenerator : IComponentGenerator<TextGeneratorContext>
    {
        public async Task<TextGeneratorContext> Generate(SkillFlowComponent component, TextGeneratorContext context)
        {
            if (component is Roll roll)
            {
                var output = $"roll {roll.Dice}d{roll.Sides}";
                if (roll.Top.HasValue)
                {
                    output = $"{output}k{roll.Top.Value}";
                }

                if (roll.Modifier.HasValue && roll.ModifyAmount.HasValue)
                {
                    output = $"{output} {roll.Modifier.Value} {roll.ModifyAmount.Value}";
                }
                await context.WriteLine(output);
            }

            return context;
        }
    }
}
