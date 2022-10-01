using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class GroupServices:IGroupServices
{
    private readonly DataContext _context;

    public GroupServices(DataContext context)
    {
        _context = context;
    }

/////////////////////////////////////////////////////blue//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<List<Group>>> GetGroup()
    {
        var fin = await _context.Groups.ToListAsync();
        return new Response<List<Group>>(fin.ToList());
    }

/////////////////////////////////////////////////////green////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public async Task<Response<Group>> AddGroup(Group group)
       {
           _context.Groups.Add(group);
           await _context.SaveChangesAsync();
           return new Response<Group>(group);
       } 
      /////////////////////////////////////////////////////Yellow////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public async Task<Response<Group>> UpdateGroup(Group group)
    {
        var record = await _context.Groups.FindAsync(group.Id);
        if (record == null) return new Response<Group>(System.Net.HttpStatusCode.NotFound, "not record found");
        record.GroupNick = group.GroupNick;
        await _context.SaveChangesAsync();
        return new Response<Group>(record);

    }
/////////////////////////////////////////////////////Red////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 public async Task<Response<string>> DeleteGroup(int id)
    {
        var record = await _context.Groups.FindAsync(id);
        if (record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "not found");
        _context.Groups.Remove(record);
        return new Response<string>("success");
    }
}