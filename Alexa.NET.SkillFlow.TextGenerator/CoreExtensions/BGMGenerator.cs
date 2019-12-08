using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.SkillFlow.CoreExtensions;
using Alexa.NET.SkillFlow.Generator;

namespace Alexa.NET.SkillFlow.TextGenerator.CoreExtensions
{
    public class BGMGenerator : IComponentGenerator<TextGeneratorContext>
    {
        public async Task<TextGeneratorContext> Generate(SkillFlowComponent component, TextGeneratorContext context)
        {
            if (component is BGM bgm)
            {
                await context.WriteLine($"BGM {bgm.Uri}");
            }

            return context;
        }
    }
}
