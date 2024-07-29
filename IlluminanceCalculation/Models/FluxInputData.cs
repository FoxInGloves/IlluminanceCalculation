namespace IlluminanceCalculation.Models;

public enum TotalReflection
{
    _70_50_30,
    _70_30_10,
    _50_50_30,
    _50_30_10,
    _30_10_10
}

public enum LuminousIntensityCurveType
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

public readonly record struct FluxInputData(
    int Length,
    int Width,
    int Height,
    float HeightWorkingSurface,
    int NormalIllumination,
    float ReserveCoefficient,
    TotalReflection TotalReflection,
    LuminousIntensityCurveType TypeOfLuminousIntensityCurve);
