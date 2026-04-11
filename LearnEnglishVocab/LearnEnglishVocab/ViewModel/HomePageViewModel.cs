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
        public HomePageViewModel(VocabularyData selectedItem) 
        {
            this.itemId = selectedItem.id;
        }
        
        [ObservableProperty]
        private VocabularyData selectedItem;

        [ObservableProperty]
        private ObservableCollection<VocabularyData> lastSeen = new ObservableCollection<VocabularyData>()
        {
            new VocabularyData("Course1", "A1", "English", "Hello", "Cześć"),
            new VocabularyData("Course2", "A1", "English", "Hello", "Cześć"),
            new VocabularyData("Course3", "A1", "English", "Hello", "Cześć"),
            new VocabularyData("Course4", "A1", "English", "Hello", "Cześć"),
        };
        [ObservableProperty]
        public ObservableCollection<VocabularyData> allCourses = new ObservableCollection<VocabularyData>();

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
