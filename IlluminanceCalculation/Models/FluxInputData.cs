using System.ComponentModel;
using IlluminanceCalculation.ViewModels;

namespace IlluminanceCalculation.Models;

public enum KssType
{
    M,
    D1,
    D2,
    G1,
    G2,
    G3,
    G4,
    K1,
    K2
}

public enum TotalReflection
{
    _70_50_30,
    _70_30_10,
    _50_50_30,
    _50_30_10,
    _30_10_10
}


public readonly struct FluxInputData
{
    public readonly float Length;

    public readonly float Width;

    public readonly float Height;

    public readonly float HeightWorkingSurface;

    public readonly TotalReflection TotalReflection;

    public readonly float NormalIllumination;

    public readonly float ReserveCoefficient;

    public readonly KssType TypeOfKss;

    public FluxInputData(int length, int width, int height, float heightWorkingSurface, TotalReflection totalReflection,
        int normalIllumination, float reserveCoefficient, KssType typeOfKss)
    {
        Length = length;
        Width = width;
        Height = height;
        HeightWorkingSurface = heightWorkingSurface;
        TotalReflection = totalReflection;
        NormalIllumination = normalIllumination;
        ReserveCoefficient = reserveCoefficient;
        TypeOfKss = typeOfKss;
    }
}