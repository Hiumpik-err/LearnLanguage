using LearnEnglishVocab.ViewModel;

namespace LearnEnglishVocab.View;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
		BindingContext = new LoggingAndRegistration();
	}
}