using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Participant
{
    public int Id { get; set; }
    
    [Required,MaxLength(100)]
    public string? FullName { get; set; }
    
    [Required,MaxLength(100)]
    public string? Email { get; set; }
    
    [Required,MaxLength(100)]
    public string? Phone { get; set; }
    
    [Required,MaxLength(100)]
    public string? Password { get; set; }
    
    public DateTime CreatedAt {get;set;}
    
    public int GroupId {get;set;}
    public virtual  Group   Group { get; set; }
    
    public int LocationId {get;set;}
    public virtual Location  Location { get; set; }
    
}