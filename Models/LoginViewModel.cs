using System.ComponentModel.DataAnnotations;

namespace CMS12.Alloy.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
