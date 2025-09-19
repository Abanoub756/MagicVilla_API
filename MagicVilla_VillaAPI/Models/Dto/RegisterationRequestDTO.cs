namespace MagicVilla_VillaAPI.Models.Dto
{
    public class RegisterationRequestDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } 
    }
}
