using System;

namespace IlluminanceCalculation.Models;

public sealed class FluxCalculator
{
    private readonly FluxUtilizationTable _utilizationTable;

    public FluxCalculator(FluxUtilizationTable utilizationTable)
    {
        _utilizationTable = utilizationTable ?? throw new ArgumentNullException(nameof(utilizationTable));
    }

    public FluxOutputData Calculate(FluxInputData data)
    {
        var area = data.Length * data.Width;
        
        var roomIndex = area / ((data.Height - data.HeightWorkingSurface) * (data.Length + data.Width));

        var fluxUtilization = _utilizationTable.GetFluxUtilization(roomIndex, data.TotalReflection, data.TypeOfLuminousIntensityCurve);
        
        var totalLuminous = 100 * data.NormalIllumination * area * 1.1f * data.ReserveCoefficient / fluxUtilization;

        return new FluxOutputData(roomIndex, fluxUtilization, totalLuminous);
    }
}