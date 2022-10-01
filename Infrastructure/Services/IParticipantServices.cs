using Domain.Entities;
using Domain.Wrapper;

namespace Infrastructure.Services;

public interface IParticipantServices
{
    Task<Response<List<Participant>>> GetParticipant();
    Task<Response<Participant>> AddParticipant(Participant participant);
    Task<Response<Participant>> UpdateParticipant(Participant participant);
    Task<Response<string>> DeleteParticipant(int id);
}