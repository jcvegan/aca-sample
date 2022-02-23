namespace CustomAuth.Services
{
    public interface ITokenValidator
    {
        bool IsValid(string token);
    }
}
