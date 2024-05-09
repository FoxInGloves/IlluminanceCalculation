namespace IlluminanceCalculation.Models;

public readonly struct FluxOutputData
{
    public readonly float RoomIndex;

    public readonly float UtilizationCoefficient;

    public readonly float TotalLuminous;

    public FluxOutputData(float roomIndex, float utilizationCoefficient, float totalLuminous)
    {
        RoomIndex = roomIndex;
        UtilizationCoefficient = utilizationCoefficient;
        TotalLuminous = totalLuminous;
    }
}