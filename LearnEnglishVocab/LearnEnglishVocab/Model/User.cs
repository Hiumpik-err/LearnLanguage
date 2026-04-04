using System;
using System.Collections.Generic;
using System.Text;


namespace LearnEnglishVocab.Model
{
    public class User
    {
        private int Id { get; set; }
        private string Password { get; set => MakePassword(field); }
        private string Email { get; set; }
        private string Username { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age {  get; set; }


        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        private string MakePassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);




    }
}
