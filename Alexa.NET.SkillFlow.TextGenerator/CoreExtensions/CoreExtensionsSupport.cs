using Alexa.NET.SkillFlow.CoreExtensions;

namespace Alexa.NET.SkillFlow.TextGenerator.CoreExtensions
{
    public static class CoreExtensionsSupport
    {
        public static void AddCoreExtensions(this TextGenerator generator)
        {
            generator.Extensions.Add(typeof(Buy), new BuyGenerator());
            generator.Extensions.Add(typeof(Time), new TimeGenerator());
            generator.Extensions.Add(typeof(BGM), new BGMGenerator());
            generator.Extensions.Add(typeof(Roll), new RollGenerator());
        }
    }
}
