using WebXeDapAPI.Models.Enum;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebXeDapAPI.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}
