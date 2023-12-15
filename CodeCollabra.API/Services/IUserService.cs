using CodeCollabra.Domain;

namespace CodeCollabra.API.Services
{
    public interface IUserService: IDisposable
    {
        IEnumerable<User> GetUsers();
    }
}
