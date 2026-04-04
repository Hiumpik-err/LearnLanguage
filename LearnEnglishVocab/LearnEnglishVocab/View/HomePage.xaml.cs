using LearnEnglishVocab.ViewModel;

namespace LearnEnglishVocab.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}
}