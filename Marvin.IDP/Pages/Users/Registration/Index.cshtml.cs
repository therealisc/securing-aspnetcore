using Duende.IdentityServer;
using Duende.IdentityServer.Services;
using IdentityModel;
using Marvin.IDP.Services;
using Marvin.IDP.Users.Registration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Marvin.IDP.Pages.Users.Registration;

[AllowAnonymous]
[SecurityHeaders]
public class IndexModel : PageModel
{
    private readonly ILocalUserService _localUserService;
    private readonly IIdentityServerInteractionService _interaction;

    public IndexModel(ILocalUserService localUserService, IIdentityServerInteractionService interaction)
    {
        _localUserService = localUserService;
        _interaction = interaction;
    }

    [BindProperty]
    public InputModel Input { get; set; }

    public IActionResult OnGet(string returnUrl)
    {
        BuildModel(returnUrl);
        return Page();
    }

    private void BuildModel(string returnUrl)
    {
        Input = new InputModel
        {
            ReturnUrl = returnUrl
        };
    }

    public async Task<IActionResult> OnPost()
    {
        if(!ModelState.IsValid)
        {
            BuildModel(Input.ReturnUrl);
            return Page();
        }

        var userToCreate = new Entities.User
        {
            UserName = Input.UserName,
            Subject = Guid.NewGuid().ToString(),
            Email = Input.Email,
            Active = false
        };

        userToCreate.Claims.Add(new Entities.UserClaim()
        {
            Type = "country",
            Value = Input.Country
        });

        userToCreate.Claims.Add(new Entities.UserClaim()
        {
            Type = JwtClaimTypes.GivenName,
            Value = Input.GivenName
        });

        userToCreate.Claims.Add(new Entities.UserClaim()
        {
            Type = JwtClaimTypes.FamilyName,
            Value = Input.FamilyName
        });

        _localUserService.AddUser(userToCreate, Input.Password);
        await _localUserService.SaveChangesAsync();

        // create an activation link
        // we use Url.PageLink
        var activationLink = Url.PageLink("/users/activation/index", values: new {securityCode = userToCreate.Subject});

        Console.WriteLine(activationLink);
        

        return Redirect("~/Users/ActivationCodeSent");

        //var isUser = new IdentityServerUser(userToCreate.Subject)
        //{
        //    DisplayName = userToCreate.UserName
        //};

        //await HttpContext.SignInAsync(isUser);

        //if(_interaction.IsValidReturnUrl(Input.ReturnUrl) || Url.IsLocalUrl(Input.ReturnUrl))
        //{
        //    return Redirect(Input.ReturnUrl);
        //}

        //return Redirect("~/");
    }
}
