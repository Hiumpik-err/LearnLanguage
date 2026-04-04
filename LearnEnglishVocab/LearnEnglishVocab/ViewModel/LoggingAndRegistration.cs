using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using LearnEnglishVocab.Model;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace LearnEnglishVocab.ViewModel
{
    [ObservableObject]
    public partial class LoggingAndRegistration
    {
        private static readonly HttpClient _httpClient = new HttpClient();


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
            try
            {
                if (Emaill is null || Password is null) throw new Exception("Essential data is empty");
                User newUser = new User(Emaill, Password);
                newUser.FirstName = Firstname ?? string.Empty;
                newUser.LastName = Lastname ?? string.Empty;
                newUser.Age = Age;
                newUser.Username = Username ?? string.Empty;

                string json = JsonSerializer.Serialize(newUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string path = "http://localhost:8000/api/register";
                HttpResponseMessage response = await _httpClient.PostAsync(path, content);

                if (response.IsSuccessStatusCode) await Shell.Current.GoToAsync("/home");
                else throw new Exception("Invalid data");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Warning", ex.Message, "OK");
            }


        }



    }
}
