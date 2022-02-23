using CustomAuth.Models.Services;

namespace CustomAuth.Services
{
    public interface ISessionService
    {
        SessionModel CreateSession(string username, string password);
    }
}
