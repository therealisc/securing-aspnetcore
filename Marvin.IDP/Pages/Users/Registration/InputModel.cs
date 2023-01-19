using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Marvin.IDP.Users.Registration;

public class InputModel
{
    public string ReturnUrl { get; set; }

    [MaxLength(200)]
    [Display(Name = "Username")]
    public string UserName { get; set; }

    [MaxLength(200)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [MaxLength(250)]
    [Required]
    [Display(Name = "Given name")]
    public string GivenName { get; set; }

    [MaxLength(250)]
    [Required]
    [Display(Name = "Family name")]
    public string FamilyName { get; set; }
    
    public string Email { get; set; }

    [Required]
    [MaxLength(2)]
    [Display(Name = "Country")]
    public string Country { get; set; }

    public SelectList CountryCodes { get; set; } = new(
        new []
        {
            new { Id = "be", Value = "Belgium" },
            new { Id = "us", Value = "United States of America" },
            new { Id = "in", Value = "India" },
        }, "Id", "Value");
}
