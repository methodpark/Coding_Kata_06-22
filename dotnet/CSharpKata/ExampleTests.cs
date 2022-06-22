using FluentAssertions;
using Moq;
using Xunit;

namespace CSharpKata;

public class ExampleTests
{
    [Fact]
    public void Double_WithoutArgument_Returns0()
    {
        var result = Example.Double();

        result.Should().Be(0);
    }

    [Theory]
    [InlineData(-1, -2)]
    [InlineData(0, 0)]
    [InlineData(1, 2)]
    [InlineData(2, 4)]
    public void Double_WithArgument_ReturnsTwiceTheInput(int input, int expected)
    {
        var result = Example.Double(input);

        result.Should().Be(expected);
    }


    public static IEnumerable<object[]> DistanceTestData =>
        new List<object[]>
        {
            new object[] {new Coordinate(0.0, 0.0), new Coordinate(0.0, 0.0), 0.0},
            new object[] {new Coordinate(0.0, 0.0), new Coordinate(0.0, 1.0), 1.0},
            new object[] {new Coordinate(0.0, 0.0), new Coordinate(1.0, 0.0), 1.0},
            new object[] {new Coordinate(0.0, 0.0), new Coordinate(1.0, 1.0), 1.414214},
        };

    [Theory]
    [MemberData(nameof(DistanceTestData))]
    public void Distance_TwoCoordinates_ReturnsTheDistance(
        Coordinate c1, Coordinate c2, double expected)
    {
        var result = Example.Distance(c1, c2);

        result.Should().BeApproximately(expected, precision: 0.000001);
    }


    [Fact]
    public void GetRandomString_WithRealRandomizer_ReturnsCorrectlyFormattedString()
    {
        var example = new Example();

        var result = example.GetRandomString();

        result.Should().Match(@"Your random number is *.");
    }

    [Fact]
    public void GetRandomString_WithMockedRandomizer_ReturnsStringWithMockedRandomNumber()
    {
        const int randomNumber = 42;
        var randomizerMock = new Mock<IRandomize>();
        randomizerMock.Setup(r => r.GetRandomNumber()).Returns(randomNumber);
        var example = new Example(randomizerMock.Object);

        var result = example.GetRandomString();

        result.Should().Be($"Your random number is {randomNumber}.");
    }
}
