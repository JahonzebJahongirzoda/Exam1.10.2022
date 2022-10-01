using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("controller")]
public class ParticipantController:ControllerBase
{
    private readonly IParticipantServices _challengeService;

    public ParticipantController(IParticipantServices challengeService )
    {
        _challengeService = challengeService;
    }

    [HttpGet ("GetParticipant")]
    public async Task<Response<List<Participant>>> GetParticipant()
    {
        return await  _challengeService.GetParticipant();
    }
    
    [HttpPut ("UpdateParticipant")]
    public async Task<Response<Participant>> UpdateParticipant(Participant challenge)
    {
        return await  _challengeService.UpdateParticipant(challenge);
    }
    
    [HttpDelete ("DeleteParticipant")]
    public async Task<Response<string>> DeleteParticipant(int id)
    {
        return await  _challengeService.DeleteParticipant(id);
    }
    
    [HttpPost("AddParticipant")]
    public async Task<Response<Participant>> AddParticipant(Participant challenge)
    {
        return await  _challengeService.AddParticipant(challenge);
    }
    
    

}