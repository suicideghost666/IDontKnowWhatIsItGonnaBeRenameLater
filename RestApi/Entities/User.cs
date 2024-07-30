using DeadInside.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace DeadInside.Domain.Entities
{
    public class User : Entity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public DateTime ProfileCreated { get; set; }
        public ICollection<Message> Messages { get; set; }
        public User() { }
        public User(string userName, string password, string email, DateTime birthday, DateTime profileCreated)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Birthday = birthday;
            ProfileCreated = profileCreated;
            Messages = new List<Message>();
        }
    }
}
