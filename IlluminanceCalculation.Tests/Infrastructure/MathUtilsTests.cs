using IlluminanceCalculation.Infrastructure;

namespace Tests.Infrastructure;

public class MathUtilsTests
{
    [Fact]
    public void Interpolate_X0p5_Returns27()
    {
        var input = (0.5f, new [] {0.6f, 0.8f}, new [] {35f, 50f});
        
        var interpolate = MathUtils.Interpolate(input.Item1, input.Item2, input.Item3);
        var interpolateRound = Math.Round(interpolate);
        
        Assert.True(Math.Abs(27 - interpolateRound) < 0.001f);
    }

    [Fact]
    public void Extrapolate_X8_Returns113()
    {
        var input = (8f, new [] {3f, 5f}, new [] {83f, 95f});
        
        var extrapolate = MathUtils.Extrapolate(input.Item1, input.Item2, input.Item3);
        var extrapolateRound = Math.Round(extrapolate);
        
        Assert.True(Math.Abs(113 - extrapolateRound) < 0.001f);
    }
}