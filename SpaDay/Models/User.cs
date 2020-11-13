using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime JoinDate { get; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            //JoinDate = DateTime.Now;
        }

        public User() {

            JoinDate = DateTime.Now;

        }
    }
}
