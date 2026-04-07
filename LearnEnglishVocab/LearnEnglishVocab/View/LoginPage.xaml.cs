namespace LearnEnglishVocab.View;
using LearnEnglishVocab.ViewModel;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoggingAndRegistration();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
    }
}