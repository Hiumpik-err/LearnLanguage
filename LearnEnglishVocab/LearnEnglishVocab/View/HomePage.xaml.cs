using LearnEnglishVocab.ViewModel;

namespace LearnEnglishVocab.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
        var viewModel = BindingContext as HomePageViewModel;

		for(int i = 0; i < 100; i++)
		{
			viewModel.AllCourses.Add(new Model.VocabularyData("Course" + i, "A1", "English", "Hello", "Cześć"));

        }

    }
}