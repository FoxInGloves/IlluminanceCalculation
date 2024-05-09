using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IlluminanceCalculation.Models;

namespace IlluminanceCalculation.ViewModels;

public sealed partial class MainViewModel : ObservableObject
{
    private readonly FluxCalculator _fluxCalculator;

    [ObservableProperty]
    private int _length = 1;

    [ObservableProperty] 
    private int _width = 1;

    [ObservableProperty]
    private int _height = 1;

    [ObservableProperty] 
    private float _heightWorkingSurface ;

    [ObservableProperty]
    private int _normalIllumination = 1;

    [ObservableProperty] 
    private float _reverseCoefficient = 1;

    [ObservableProperty] 
    private KssType _typeOfKss = KssType.M;

    [ObservableProperty] 
    private TotalReflection _totalReflection = TotalReflection._70_50_30;

    [ObservableProperty] 
    private string _calculationResult;

    [ObservableProperty] 
    private string _output;

    public MainViewModel(FluxCalculator fluxCalculator)
    {
        _fluxCalculator = fluxCalculator ?? throw new ArgumentNullException(nameof(fluxCalculator));
    }

    [RelayCommand]
    private void Calculate()
    {
        var data = new FluxInputData(Length, Width, Height, HeightWorkingSurface, TotalReflection, NormalIllumination,
            ReverseCoefficient, TypeOfKss);
        
        var result = _fluxCalculator.Calculate(data);
        
        Output = $"Индекс помещения: {MathF.Round(result.RoomIndex, 2)}\n" +
                 $"Коэфф. использования светового потока: {MathF.Round(result.UtilizationCoefficient, 2)}\n" +
                 $"Световой поток: {MathF.Round(result.TotalLuminous, 2)}";
    }
}