using FundamentosIGMaui.Views.Layouts.GridSample;

namespace FundamentosIGMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new GridLayoutChallenge();
	}
}
