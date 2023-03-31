using TAO.Calculator.MVVM;

namespace TAO.Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
