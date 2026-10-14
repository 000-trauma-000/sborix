namespace JWT.Dto
{
    public class RefreshRequestDto
    {
        public string AccessToken {get; set;}
        public string RefreshToken {get; set;}
        public DateTime ExpiresAt { get; set;}

    }
    
}