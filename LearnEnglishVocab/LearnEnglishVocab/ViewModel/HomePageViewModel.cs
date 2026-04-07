using CommunityToolkit.Mvvm.ComponentModel;
using LearnEnglishVocab.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearnEnglishVocab.ViewModel
{
    [ObservableObject]
    public partial class HomePageViewModel
    {
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
    }
}
