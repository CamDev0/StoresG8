using StoresG8.Shared.Entities;

namespace StoresG8.Shared.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;

        public DateTime Expiration { get; set; }
    }
}
