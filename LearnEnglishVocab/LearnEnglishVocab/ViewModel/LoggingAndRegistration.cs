using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearnEnglishVocab.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LearnEnglishVocab.ViewModel
{
    [ObservableObject]
    public partial class LoggingAndRegistration
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string URL = "http://10.0.2.2/api";


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
        public async void Login()
        {
            try
            {
                if (Username is null || Password is null) throw new Exception("Essential Data is empty");
                User newUser = new User(Username, Password);

                string path = URL + "/login";
                string json = JsonSerializer.Serialize(newUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(path, content);

                if (response.IsSuccessStatusCode)
                {
                    await Shell.Current.GoToAsync("/home");
                }


            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("WARNING", ex.Message, "OK");
            }
        }
        [RelayCommand]
        public async void GoToRegistration() => await Shell.Current.GoToAsync("/registration");
        public async void GoToLoginPage() => await Shell.Current.GoToAsync("/logining");


        [RelayCommand]
        public async void Register()
        {
            if (await CheckIfJWTExists())
            {
                await Shell.Current.GoToAsync("/home");
                return;
            }

            try
            {
                if (Emaill is null || Password is null) throw new Exception("Essential data is empty");
                User newUser = new User(Emaill, Password);
                newUser.firstname = Firstname ?? string.Empty;
                newUser.lastname = Lastname ?? string.Empty;
                newUser.age = Age;
                newUser.username = Username ?? string.Empty;

                string json = JsonSerializer.Serialize(newUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string path = URL + "/register";
                HttpResponseMessage response = await _httpClient.PostAsync(path, content);

                if (response.IsSuccessStatusCode)
                {
                    //await SecureStorage.SetAsync("secretKey", response.Content);
                    await Shell.Current.GoToAsync("/home");
                }
                else throw new Exception(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Warning", ex.Message, "OK");
            }


        }

        private async Task<bool> CheckIfJWTExists() => await SecureStorage.GetAsync("secretKey") is not null;




    }
}
