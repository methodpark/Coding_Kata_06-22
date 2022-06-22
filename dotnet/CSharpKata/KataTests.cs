using FluentAssertions;
using Xunit;

namespace CSharpKata;

public class KataTests
{
    [Fact]
    public void Write_Your_Tests_here()
    {
        Kata.ImplementStuff.Should().Be(42);
    }
}
