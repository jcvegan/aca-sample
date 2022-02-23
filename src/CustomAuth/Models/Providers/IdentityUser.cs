namespace CustomAuth.Models.Providers
{
    public record IdentityUser
    {
        public string Username { get; init; } = string.Empty;
        public string Alias { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public string[] MemberOf { get; set; } = new string[] { };
    }
}
