using Microsoft.AspNetCore.Identity;

namespace App_Consultorio.Web.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<App_Consultorio.Domain.Entities.ApplicationUser> userManager, IdentityRedirectManager redirectManager)
{
    public async Task<App_Consultorio.Domain.Entities.ApplicationUser> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}
