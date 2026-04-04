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
        private string emaill;
        [ObservableProperty]
        private string _password;
        [ObservableProperty]
        private string firstname;
        [ObservableProperty]
        private string lastname;
        [ObservableProperty]
        private string username;
        [ObservableProperty]
        private int age;


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
        public async void GoToRegistration() => await Shell.Current.GoToAsync("/registration");
        public async void GoToLoginPage() => await Shell.Current.GoToAsync("/logining");

        
        [RelayCommand]
        public async void Register()
        {
            User newUser = new User(Emaill, Password);
            newUser.FirstName = Firstname ?? string.Empty;
            newUser.LastName = Lastname ?? string.Empty;
            newUser.Age = Age;
            newUser.Username = Username ?? string.Empty;



            await Shell.Current.GoToAsync("/home");
        }



    }
}
