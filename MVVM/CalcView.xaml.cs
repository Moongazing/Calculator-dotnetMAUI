namespace TAO.Calculator.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();

		BindingContext = new CalcView();
	}
}