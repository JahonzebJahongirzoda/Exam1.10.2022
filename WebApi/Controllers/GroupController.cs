using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("controller")]
public class GroupController:ControllerBase
{
    private readonly IGroupServices _groupService;

    public GroupController(IGroupServices challengeService )
    {
        _groupService = challengeService;
    }

    [HttpGet ("GetGroup")]
    public async Task<Response<List<Group>>> GetGroup()
    {
        return await  _groupService.GetGroup();
    }
    
    [HttpPut ("UpdateGroup")]
    public async Task<Response<Group>> UpdateGroup(Group challenge)
    {
        return await  _groupService.UpdateGroup(challenge);
    }
    
    [HttpDelete ("DeleteGroup")]
    public async Task<Response<string>> DeleteGroup(int id)
    {
        return await  _groupService.DeleteGroup(id);
    }
    
    [HttpPost("AddGroup")]
    public async Task<Response<Group>> AddGroup(Group challenge)
    {
        return await  _groupService.AddGroup(challenge);
    }
    
    

}