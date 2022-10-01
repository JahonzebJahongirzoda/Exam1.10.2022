using Domain.Entities;
using Domain.Wrapper;

namespace Infrastructure.Services;

public interface IGroupServices
{
    Task<Response<List<Group>>> GetGroup();
    Task<Response<Group>> AddGroup(Group group);
    Task<Response<Group>> UpdateGroup(Group group);
    Task<Response<string>> DeleteGroup(int id);

}