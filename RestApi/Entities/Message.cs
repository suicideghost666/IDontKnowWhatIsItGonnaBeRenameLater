using System.ComponentModel.DataAnnotations;

namespace DeadInside.Domain.Entities
{
    public class Message
    {
        [Required]
        public string Body { get; set; }
        [Required]

        public DateTime CreatedTime;
        public Message(string body)
        {
            Body = body; 
            CreatedTime = DateTime.Now;
        }
    }
}
