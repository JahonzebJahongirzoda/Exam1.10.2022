using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Domain.Entities;



public class Challenge
{
    public int Id { get; set; }
    [MaxLength(100),Required]
    public string? Name { get; set; }
    [MaxLength(100),Required]
    public string? Description { get; set; }

    public virtual List<Group>? Group { get; set; }
}
