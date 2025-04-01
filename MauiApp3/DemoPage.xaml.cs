namespace MauiApp3;

public partial class DemoPage : ContentPage
{
	public DemoPage(DemoViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}