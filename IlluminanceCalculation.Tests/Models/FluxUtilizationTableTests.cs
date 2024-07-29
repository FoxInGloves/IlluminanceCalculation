using IlluminanceCalculation.Models;

namespace Tests.Models;

public class FluxUtilizationTableTests
{
    [Fact]
    public void GetFluxUtilization_RoomIndexGreater5_Returns92FluxUtilization()
    {
        var utilizationTable = new FluxUtilizationTable();

        var fluxUtilization =
            utilizationTable.GetFluxUtilization(6, TotalReflection._50_30_10, LuminousIntensityCurveType.D2);
        var fluxUtilizationRound = Math.Round(fluxUtilization);
        
        Assert.True(Math.Abs(92 - fluxUtilizationRound) < 0.001);
    }

    [Fact]
    public void GetFluxUtilization_RoomIndex2p6_Returns73FluxUtilization()
    {
        var utilizationTable = new FluxUtilizationTable();
        
        var fluxUtilization = 
            utilizationTable.GetFluxUtilization(2.6f, TotalReflection._50_30_10, LuminousIntensityCurveType.D2);
        var fluxUtilizationRound = Math.Round(fluxUtilization);
        
        Assert.True(Math.Abs(73 - fluxUtilizationRound) < 0.001);
    }

    [Fact]
    public void GetFluxUtilization_RoomIndexLess0p6_Returns15FluxUtilization()
    {
        var utilizationTable = new FluxUtilizationTable();
        
        var fluxUtilization = 
            utilizationTable.GetFluxUtilization(0.2f, TotalReflection._50_30_10, LuminousIntensityCurveType.D2);
        var fluxUtilizationRound = Math.Round(fluxUtilization);
        
        Assert.True(Math.Abs(15 - fluxUtilizationRound) < 0.001);
    }
}