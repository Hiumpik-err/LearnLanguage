using System;
using System.Collections.Generic;
using System.Text;


namespace LearnEnglishVocab.Model
{
    public class User
    {
        public string Password { get; set => field = MakePassword(value); }
        public string Email { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age {  get; set; }


        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        private string MakePassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);




    }
}
