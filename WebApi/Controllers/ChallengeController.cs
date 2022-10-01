using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("controller")]
public class ChallengeController:ControllerBase
{
    private readonly IChallengeService _challengeService;

    public ChallengeController(IChallengeService challengeService )
    {
        _challengeService = challengeService;
    }

    [HttpGet ("GetChallenge")]
    public async Task<Response<List<Challenge>>> GetChallenge()
    {
        return await  _challengeService.GetChallenge();
    }
    
    [HttpPut ("UpdateChallenge")]
    public async Task<Response<Challenge>> UpdateChallenge(Challenge challenge)
    {
        return await  _challengeService.UpdateChallenge(challenge);
    }
    
    [HttpDelete ("DeleteChallenge")]
    public async Task<Response<string>> DeleteChallenge(int id)
    {
        return await  _challengeService.DeleteChallenge(id);
    }
    
    [HttpPost("AddChallenge")]
    public async Task<Response<Challenge>> AddChallenge(Challenge challenge)
    {
        return await  _challengeService.AddChallenge(challenge);
    }
    
    

}