using Domain.Entities;
using Domain.Wrapper;


namespace Infrastructure.Services;

public interface IChallengeService
{
    Task<Response<string>> DeleteChallenge(int id);
    Task<Response<List<Challenge>>> GetChallenge();
    Task<Response<Challenge>> AddChallenge(Challenge challenge);
    Task<Response<Challenge>> UpdateChallenge(Challenge challenge);
}