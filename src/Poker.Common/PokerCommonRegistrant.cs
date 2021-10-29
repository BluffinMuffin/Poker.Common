using System.Diagnostics.CodeAnalysis;
using BluffinMuffin.Poker.Common.Helpers;
using Com.Ericmas001.DependencyInjection.Registrants;

namespace BluffinMuffin.Poker.Common
{
    [ExcludeFromCodeCoverage]
    public class PokerCommonRegistrant : AbstractRegistrant
    {
        protected override void RegisterEverything()
        {
            Register<IStringCardHelper, StringCardHelper>();
        }
    }
}
