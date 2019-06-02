using System;

namespace ConversionTest
{
    public class MainConverter
    {

    }

    public interface IConversion
    {
        string Name { get; }
        string Version { get; }
        object Input { get; }
        object Output { get; }
    }
}
