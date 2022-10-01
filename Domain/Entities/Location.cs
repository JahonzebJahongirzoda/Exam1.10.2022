using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Location
{
    public int Id { get; set; }
    [MaxLength(100),Required]
    public string? Name { get; set; }
    [MaxLength(100),Required]
    public string? Description { get; set; }
    public virtual List<Participant>? Participants { get; set; }
}