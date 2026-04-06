using System;
using System.Collections.Generic;
using System.Text;


namespace LearnEnglishVocab.Model
{
    public class User
    {
        public string password { get; set => field = MakePassword(value); }
        public string email { get; set; }
        public string? username { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int? age {  get; set; }


        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        private string MakePassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);




    }
}
