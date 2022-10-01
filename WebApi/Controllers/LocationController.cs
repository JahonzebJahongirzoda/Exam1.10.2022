using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("controller")]
public class LocationController:ControllerBase
{
    private readonly ILocationServices _challengeService;

    public LocationController(ILocationServices challengeService )
    {
        _challengeService = challengeService;
    }

    [HttpGet ("GetLocation")]
    public async Task<Response<List<Location>>> GetLocation()
    {
        return await  _challengeService.GetLocation();
    }
    
    [HttpPut ("UpdateLocation")]
    public async Task<Response<Location>> UpdateLocation(Location challenge)
    {
        return await  _challengeService.UpdateLocation(challenge);
    }
    
    [HttpDelete ("DeleteLocation")]
    public async Task<Response<string>> DeleteLocation(int id)
    {
        return await  _challengeService.DeleteLocation(id);
    }
    
    [HttpPost("AddLocation")]
    public async Task<Response<Location>> AddLocation(Location challenge)
    {
        return await  _challengeService.AddLocation(challenge);
    }
    
    

}