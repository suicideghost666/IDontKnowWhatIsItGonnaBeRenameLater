using System.ComponentModel.DataAnnotations;

namespace DeadInside.Domain.Entities.Base
{
    public class Entity
    {
        [Key]
        Guid Id { get; set; }
    }
}
