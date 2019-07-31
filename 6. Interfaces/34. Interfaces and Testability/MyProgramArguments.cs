using NClap.Metadata;

namespace Interfaces_and_Testability
{
    public class MyProgramArguments
    {
        [NamedArgument]
        public int ImportantValue { get; set; }
    }
}
