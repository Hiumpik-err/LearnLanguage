using LearnEnglishVocab.ViewModel;

namespace LearnEnglishVocab.View;

[QueryProperty(nameof(CourseId), "id")]
public partial class CoursePage : ContentPage
{
	public int CourseId { get; set; }
    public CoursePage()
	{
		InitializeComponent();
		BindingContext = new CourseViewModel();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();




    }
}