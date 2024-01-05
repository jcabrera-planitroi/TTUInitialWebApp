using Microsoft.AspNetCore.Identity;

namespace TTUInitialWebApp.Entities;

public class ApplicationUser : IdentityUser
{
    //User Contact And Owner Information
    public ICollection<UserInformation>? UserInformationCollection { get; set; }
    
}