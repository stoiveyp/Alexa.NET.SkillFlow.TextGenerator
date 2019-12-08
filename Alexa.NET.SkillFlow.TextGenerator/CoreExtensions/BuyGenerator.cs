using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alexa.NET.SkillFlow.CoreExtensions;
using Alexa.NET.SkillFlow.Generator;

namespace Alexa.NET.SkillFlow.TextGenerator.CoreExtensions
{
    public class BuyGenerator:IComponentGenerator<TextGeneratorContext>
    {
        public async Task<TextGeneratorContext> Generate(SkillFlowComponent component, TextGeneratorContext context)
        {
            if (component is Buy buy)
            {
                await context.WriteString($"buy item=\"{buy.Item}\" success=\"{buy.SuccessScene}\" fail=\"{buy.FailureScene}\"");
                if (!string.IsNullOrWhiteSpace(buy.DeclinedScene))
                {
                    await context.WriteString($" declined=\"{buy.DeclinedScene}\"");
                }
                if (!string.IsNullOrWhiteSpace(buy.AlreadyPurchasedScene))
                {
                    await context.WriteString($" already_purchased=\"{buy.AlreadyPurchasedScene}\"");
                }
                if (!string.IsNullOrWhiteSpace(buy.ErrorScene))
                {
                    await context.WriteString($" error=\"{buy.ErrorScene}\"");
                }

                await context.WriteLine(string.Empty);
            }

            return context;
        }
    }
}
