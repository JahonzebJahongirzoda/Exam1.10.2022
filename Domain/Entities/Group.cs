using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Domain.Entities;

public class Group
{
    public int Id { get; set; }
    
    [Required,MaxLength(500)]
    public string? GroupNick { get; set; }

    public virtual Challenge? Challenge { get; set; }
    public int ChallangeId { get; set; }
    
    public bool NeededMember { get; set; }
     
    [Required,MaxLength(500)]
    public string? TeamSlogan { get; set; }
    
    public int CreatedAt { get; set; }

    public virtual List<Participant>? Participants { get; set; }



}