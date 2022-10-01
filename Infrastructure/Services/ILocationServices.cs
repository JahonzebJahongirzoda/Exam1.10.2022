using Domain.Entities;
using Domain.Wrapper;

namespace Infrastructure.Services;

public interface ILocationServices
{
    Task<Response<List<Location>>> GetLocation();
    Task<Response<Location>> AddLocation(Location location);
    Task<Response<Location>> UpdateLocation(Location location);
    Task<Response<string>> DeleteLocation(int id);
}