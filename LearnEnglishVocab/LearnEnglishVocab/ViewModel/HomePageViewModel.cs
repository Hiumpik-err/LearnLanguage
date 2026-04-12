using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearnEnglishVocab.Model;
using LearnEnglishVocab.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearnEnglishVocab.ViewModel
{
    [ObservableObject]
    public partial class HomePageViewModel
    {
        private int itemId;
        public HomePageViewModel() { }
        public HomePageViewModel(Course selectedItem) 
        {
            this.itemId = selectedItem.id;
        }
        
        [ObservableProperty]
        private Course selectedItem;

        [ObservableProperty]
        private ObservableCollection<Course> lastSeen = new ObservableCollection<Course>()
        {
            new Course("Course1", "A1", "English", "Hello", "Cześć"),
            new Course("Course2", "A1", "English", "Hello", "Cześć"),
            new Course("Course3", "A1", "English", "Hello", "Cześć"),
            new Course("Course4", "A1", "English", "Hello", "Cześć"),
        };
        [ObservableProperty]
        public ObservableCollection<Course> allCourses = new ObservableCollection<Course>();

        [RelayCommand]
        private async void onSelectedItem()
        { 
            await Shell.Current.Navigation.PushModalAsync(new courseDetails(SelectedItem));
        }

        [RelayCommand]
        private async void CloseModal() => await Shell.Current.Navigation.PopModalAsync();

        [RelayCommand]
        private async void GoToCourse()
        {
            await Shell.Current.Navigation.PopModalAsync();
            await Shell.Current.GoToAsync($"/course?id={itemId}");
        }
    }
}
