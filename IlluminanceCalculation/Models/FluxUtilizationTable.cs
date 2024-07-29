using System;
using System.Collections.Generic;
using IlluminanceCalculation.Infrastructure;

namespace IlluminanceCalculation.Models;

public sealed partial class FluxUtilizationTable
{
    private sealed class ReflectionCoefficientMap : Dictionary<LuminousIntensityCurveType, List<float>>
    {
    }
}

public sealed partial class FluxUtilizationTable
{
    private readonly Dictionary<TotalReflection, ReflectionCoefficientMap> _reflectionCoefficientMaps = new()
    {
        {TotalReflection._70_50_30, new ReflectionCoefficientMap
        {
            { LuminousIntensityCurveType.M , new List<float>(){ 35, 50, 61, 73, 83, 95 }},
            { LuminousIntensityCurveType.D1 , new List<float>(){ 36, 50, 61, 72, 81, 90 }},
            { LuminousIntensityCurveType.D2 , new List<float>() { 44, 52, 68, 84, 93, 103 }},
            { LuminousIntensityCurveType.G1 , new List<float>(){ 49, 60, 75, 90, 101, 106 }},
            { LuminousIntensityCurveType.G2 , new List<float>() { 58, 68, 82, 96, 102, 109 }},
            { LuminousIntensityCurveType.G3 , new List<float>(){ 64, 74, 85, 95, 100, 105 }},
            { LuminousIntensityCurveType.G4 , new List<float>(){ 70, 77, 84, 90, 94, 99 }},
            { LuminousIntensityCurveType.K1 , new List<float>(){ 74, 83, 90, 96, 94, 99 }},
            { LuminousIntensityCurveType.K2 , new List<float>(){ 75, 84, 95, 104, 108, 115 }}
        }},
        {TotalReflection._70_30_10, new ReflectionCoefficientMap()
        {
            { LuminousIntensityCurveType.M , new List<float>(){ 26, 36, 46, 56, 67, 80 }},
            { LuminousIntensityCurveType.D1 , new List<float>(){ 28, 40, 49, 59, 68, 74 }},
            { LuminousIntensityCurveType.D2 , new List<float>(){ 33, 43, 56, 74, 80, 46 }},
            { LuminousIntensityCurveType.G1 , new List<float>(){42, 52, 69, 78, 73, 76 }},
            { LuminousIntensityCurveType.G2 , new List<float>(){48, 60, 73, 84, 90, 94 }},
            { LuminousIntensityCurveType.G3 , new List<float>(){ 57, 66, 76, 84, 83, 91 }},
            { LuminousIntensityCurveType.G4 , new List<float>(){ 62, 69, 76, 81, 84, 85 }},
            { LuminousIntensityCurveType.K1 , new List<float>(){ 65, 73, 81, 86, 89, 90 }},
            { LuminousIntensityCurveType.K2 , new List<float>(){ 67, 75, 84, 93, 97, 100}}
        }},
        {TotalReflection._50_50_30, new ReflectionCoefficientMap()
        {
            { LuminousIntensityCurveType.M , new List<float>(){ 32, 45, 55, 67, 74, 84 }},
            { LuminousIntensityCurveType.D1 , new List<float>(){ 36, 48, 57, 66, 76, 85 }},
            { LuminousIntensityCurveType.D2 , new List<float>(){ 42, 51, 65, 71, 90, 85 }},
            { LuminousIntensityCurveType.G1 , new List<float>(){ 45, 56, 65, 78, 76, 84 }},
            { LuminousIntensityCurveType.G2 , new List<float>(){ 55, 66, 80, 92, 98, 103 }},
            { LuminousIntensityCurveType.G3 , new List<float>(){ 63, 72, 83, 91, 96, 100 }},
            { LuminousIntensityCurveType.G4 , new List<float>(){ 68, 73, 81, 87, 91, 94 }},
            { LuminousIntensityCurveType.K1 , new List<float>(){ 70, 78, 86, 92, 96, 100 }},
            { LuminousIntensityCurveType.K2 , new List<float>(){ 72, 80, 91, 99, 103, 108 }}
        }},
        {TotalReflection._50_30_10, new ReflectionCoefficientMap()
        {
            { LuminousIntensityCurveType.M , new List<float>(){ 23, 36, 45, 56, 65, 75 }},
            { LuminousIntensityCurveType.D1 , new List<float>(){ 27, 40, 48, 55, 65, 75 }},
            { LuminousIntensityCurveType.D2 , new List<float>(){ 33, 42, 52, 69, 75, 86 }},
            { LuminousIntensityCurveType.G1 , new List<float>(){ 41, 48, 64, 76, 70, 88 }},
            { LuminousIntensityCurveType.G2 , new List<float>(){ 48, 58, 72, 83, 86, 93}},
            { LuminousIntensityCurveType.G3 , new List<float>(){ 57, 65, 75, 83, 86, 90 }},
            { LuminousIntensityCurveType.G4 , new List<float>(){ 62, 68, 74, 81, 83, 85 }},
            { LuminousIntensityCurveType.K1 , new List<float>(){ 64, 73, 80, 86, 88, 90 }},
            { LuminousIntensityCurveType.K2 , new List<float>(){ 68, 74, 84, 92, 93, 99 }}
        }},
        {TotalReflection._30_10_10, new ReflectionCoefficientMap()
        {
            { LuminousIntensityCurveType.M, new List<float>(){ 17, 29, 38, 46, 58, 67 }},
            { LuminousIntensityCurveType.D1 , new List<float>(){ 27, 35, 42, 52, 61, 68 }},
            { LuminousIntensityCurveType.D2 , new List<float>(){ 28, 36, 48, 53, 75, 81 }},
            { LuminousIntensityCurveType.G1 , new List<float>(){ 35, 45, 60, 73, 68, 77 }},
            { LuminousIntensityCurveType.G2 , new List<float>(){ 43, 54, 68, 79, 85, 90 }},
            { LuminousIntensityCurveType.G3 , new List<float>(){ 53, 62, 73, 80, 84, 86 }},
            { LuminousIntensityCurveType.G4 , new List<float>(){ 61, 65, 72, 78, 81, 83 }},
            { LuminousIntensityCurveType.K1 , new List<float>(){ 62, 71, 77, 83, 86, 88}},
            { LuminousIntensityCurveType.K2 , new List<float>(){ 68, 72, 80, 89, 93, 97 }}
        }}
    };

    private readonly float[] _roomIndexes = new []
    {
        0.6f, 0.8f, 1.25f, 2f, 3f, 5f
    };

    public float GetFluxUtilization(float roomIndex, TotalReflection totalReflection, LuminousIntensityCurveType typeOfLuminousIntensityCurve)
    {
        float[] xValues;
        float[] yValues;
        (int, int) valuesIndexes;

        int roomCoefficientUpperLimit;
            
        var targetValues = _reflectionCoefficientMaps[totalReflection][typeOfLuminousIntensityCurve].ToArray();
            
        if (roomIndex >= _roomIndexes[^1])
        {
            valuesIndexes = (targetValues.Length - 2, targetValues.Length - 1);

            xValues = GetCoefficient(valuesIndexes, _roomIndexes);
            yValues = GetCoefficient(valuesIndexes, targetValues);

            return MathUtils.Extrapolate(roomIndex, xValues, yValues);
        }

        if (roomIndex < _roomIndexes[0])
        {
            roomCoefficientUpperLimit = Array.FindIndex(_roomIndexes, value => value > roomIndex);
            
            valuesIndexes = (roomCoefficientUpperLimit, roomCoefficientUpperLimit + 1);
        }
        else
        {
            roomCoefficientUpperLimit = Array.FindIndex(_roomIndexes, value => value > roomIndex);

            valuesIndexes = (roomCoefficientUpperLimit - 1, roomCoefficientUpperLimit);
        }

        xValues = GetCoefficient(valuesIndexes, _roomIndexes);
        yValues = GetCoefficient(valuesIndexes, targetValues);

        return MathUtils.Interpolate(roomIndex, xValues, yValues);
    }

    private static float[] GetCoefficient((int, int) indexes, IReadOnlyList<float> arrayOfValues)
    {
        return new[] { arrayOfValues[indexes.Item1], arrayOfValues[indexes.Item2] };
    }
}