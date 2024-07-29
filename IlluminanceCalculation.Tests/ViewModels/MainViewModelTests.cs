using IlluminanceCalculation.ViewModels;

namespace Tests.ViewModels;

public class MainViewModelTests
{
	[Fact]
	public void ViewModelCalculate_None_NotNull()
	{
		var viewModel = new MainViewModel
			(new IlluminanceCalculation.Models.FluxCalculator(
				new IlluminanceCalculation.Models.FluxUtilizationTable()));
		
		viewModel.CalculateCommand.Execute(null);
		
		Assert.NotNull(viewModel.Output);
	}
}