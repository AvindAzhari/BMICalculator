using BMICalculator.ViewModels;

namespace BMICalculator.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
	}
}