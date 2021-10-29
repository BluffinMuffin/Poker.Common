using System.Diagnostics.CodeAnalysis;
using Com.Ericmas001.DependencyInjection.Registrants;
using Poker.Common.Helpers;

namespace Poker.Common
{
    [ExcludeFromCodeCoverage]
    public class PokerCommandRegistrant : AbstractRegistrant
    {
        protected override void RegisterEverything()
        {
            Register<IStringCardHelper, StringCardHelper>();
        }
    }
}
