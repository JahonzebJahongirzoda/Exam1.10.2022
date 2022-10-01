using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class LocationServices:ILocationServices
{
    private readonly DataContext _context;

    public LocationServices(DataContext context)
    {
        _context = context;
    }

/////////////////////////////////////////////////////blue//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<List<Location>>> GetLocation()
    {
        var fin = await _context.Locations.ToListAsync();
        return new Response<List<Location>>(fin);
    }

/////////////////////////////////////////////////////green////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public async Task<Response<Location>> AddLocation(Location location)
       {
           _context.Locations.Add(location);
           await _context.SaveChangesAsync();
           return new Response<Location>(location);
       } 
      /////////////////////////////////////////////////////Yellow////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public async Task<Response<Location>> UpdateLocation(Location location)
    {
        var record = await _context.Locations.FindAsync(location.Id);
        if (record == null) return new Response<Location>(System.Net.HttpStatusCode.NotFound, "not record found");
        record.Name = location.Name;
        await _context.SaveChangesAsync();
        return new Response<Location>(record);

    }

    public async  Task<Response<string>> DeleteLocation(int id)
    { var record = await _context.Challenges.FindAsync(id);
        if (record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "not found");
        _context.Challenges.Remove(record);
        return new Response<string>("success");
    }

    /////////////////////////////////////////////////////Red////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}