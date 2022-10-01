using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ChallengeServices:IChallengeService
{
    private readonly DataContext _context;

    public ChallengeServices(DataContext context)
    {
        _context = context;
    }

/////////////////////////////////////////////////////blue//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<List<Challenge>>> GetChallenge()
    {
        var fin = await _context.Challenges.ToListAsync();
        return new Response<List<Challenge>>(fin.ToList());
    }

/////////////////////////////////////////////////////green////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public async Task<Response<Challenge>> AddChallenge(Challenge challenge)
       {
           _context.Challenges.Add(challenge);
           await _context.SaveChangesAsync();
           return new Response<Challenge>(challenge);
       } 
      /////////////////////////////////////////////////////Yellow////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public async Task<Response<Challenge>> UpdateChallenge(Challenge challenge)
    {
        var record = await _context.Challenges.FindAsync(challenge.Id);
        if (record == null) return new Response<Challenge>(System.Net.HttpStatusCode.NotFound, "not record found");
        record.Name = challenge.Name;
        await _context.SaveChangesAsync();
        return new Response<Challenge>(record);

    }
/////////////////////////////////////////////////////Red////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<string>> DeleteChallenge(int id)
    {
        var record = await _context.Challenges.FindAsync(id);
        if (record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "not found");
        _context.Challenges.Remove(record);
        return new Response<string>("success");
    }
}