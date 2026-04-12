using LearnEnglishVocab.Model;
using LearnEnglishVocab.ViewModel;

namespace LearnEnglishVocab.View;

public partial class courseDetails : ContentPage
{
	public courseDetails(Course selectedItem)
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel(selectedItem);
    }
}