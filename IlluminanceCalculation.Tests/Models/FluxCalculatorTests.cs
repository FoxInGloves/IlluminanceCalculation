using IlluminanceCalculation.Models;

namespace Tests.Models;

public class FluxCalculatorTests
{
    [Fact]
    public void Calculate_SomeInputData_ReturnsOutputData()
    {
        var fluxCalculator = new FluxCalculator(new FluxUtilizationTable());
        var inputData = new FluxInputData(5, 4, 4, 0.7f, 70,
            1f, TotalReflection._50_30_10, LuminousIntensityCurveType.G2);

        var result = fluxCalculator.Calculate(inputData);
        
        Assert.IsType<FluxOutputData>(result);
    }
    
    [Fact]
    public void Calculate_SomeInputData_Returns1p86RoomIndex()
    {
        var fluxCalculator = new FluxCalculator(new FluxUtilizationTable());
        var inputData = new FluxInputData(11, 7, 3, 0.7f, 70,
            1f, TotalReflection._50_30_10, LuminousIntensityCurveType.G2);

        var result = fluxCalculator.Calculate(inputData);
        var roomIndexRound = Math.Round(result.RoomIndex, 2);
        
        Assert.True(Math.Abs(1.86f - roomIndexRound) < 0.001);
    }
    
    [Fact]
    public void Calculate_SomeInputData_Returns17p27TotalLuminous()
    {
        var fluxCalculator = new FluxCalculator(new FluxUtilizationTable());
        var inputData = new FluxInputData(3, 1, 2, 0.3f, 2,
            1.2f, TotalReflection._30_10_10, LuminousIntensityCurveType.G3);

        var result = fluxCalculator.Calculate(inputData);
        var totalLuminousRound = Math.Round(result.TotalLuminous, 2);
        
        Assert.True(Math.Abs(17.27f - totalLuminousRound) < 0.001);
    }
    
    [Fact]
    public void Calculate_SomeInputData_Returns36p88UtilizationCoefficient()
    {
        var fluxCalculator = new FluxCalculator(new FluxUtilizationTable());
        var inputData = new FluxInputData(1, 1, 1, 0.2f, 1,
            1f, TotalReflection._70_50_30, LuminousIntensityCurveType.M);

        var result = fluxCalculator.Calculate(inputData);
        var totalLuminousRound = Math.Round(result.UtilizationCoefficient, 2);
        
        Assert.True(Math.Abs(36.88f - totalLuminousRound) < 0.001);
    }
}