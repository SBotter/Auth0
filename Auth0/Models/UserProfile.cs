namespace Auth0.Models
{
    public class UserProfile
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string ProfileImage { get; set; } = string.Empty;   
    }
}
