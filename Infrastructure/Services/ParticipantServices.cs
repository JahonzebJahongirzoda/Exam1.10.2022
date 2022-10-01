using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ParticipantServices:IParticipantServices
{
    private readonly DataContext _context;

    public ParticipantServices(DataContext context)
    {
        _context = context;
    }

/////////////////////////////////////////////////////blue//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<List<Participant>>> GetParticipant()
    {
        var fin = await _context.Participants.ToListAsync();
        return new Response<List<Participant>>(fin.ToList());
    }

/////////////////////////////////////////////////////green////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public async Task<Response<Participant>> AddParticipant(Participant participant)
       {
           _context.Participants.Add(participant);
           await _context.SaveChangesAsync();
           return new Response<Participant>(participant);
       } 
      /////////////////////////////////////////////////////Yellow////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public async Task<Response<Participant>> UpdateParticipant(Participant participant)
    {
        var record = await _context.Participants.FindAsync(participant.Id);
        if (record == null) return new Response<Participant>(System.Net.HttpStatusCode.NotFound, "not record found");
        record.FullName = participant.FullName;
        await _context.SaveChangesAsync();
        return new Response<Participant>(record);

    }
/////////////////////////////////////////////////////Red////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<string>> DeleteParticipant(int id)
    {
        var record = await _context.Participants.FindAsync(id);
        if (record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "not found");
        _context.Participants.Remove(record);
        return new Response<string>("success");
    }
}