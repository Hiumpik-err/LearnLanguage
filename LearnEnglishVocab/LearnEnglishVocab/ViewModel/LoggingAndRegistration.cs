using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using LearnEnglishVocab.Model;

namespace LearnEnglishVocab.ViewModel
{
    [ObservableObject]
    public partial class LoggingAndRegistration
    {
        [ObservableProperty]
        private string username;
        [ObservableProperty]
        private string _password;


        [RelayCommand]
        public void ForgotPassword()
        {
            //Zapomniales hasla ? szkoda
        }
        [RelayCommand]
        public void Login()
        {
            // Login 
        }
        [RelayCommand]
        public void GoToRegistration()
        {
            User newUser = new User(Username,Password);
        }

    }
}
