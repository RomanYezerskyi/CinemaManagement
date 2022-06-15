using CinemaManagement.DAL.Entities;

namespace CinemaManagement.BL.Models.Authorization
{
    public class AuthSettings
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }

        public AuthSettings(User user, string role)
        {
            Id = user.Id;
            Email = user.Email;
            FirstName = user.UserName;
            SecondName = user.LastName;
            PhoneNumber = user.PhoneNumber;
            Role = role;
        }

        public AuthSettings(User user, string role, string token) : this(user, role)
        {
            Token = token;
        }
    }
}
