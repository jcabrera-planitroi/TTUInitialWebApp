namespace TTUInitialWebApp.Entities;

public class UserInformation
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string? Title { get; init; }
    public string CompanyName { get; init; }
    public string OfficePhone { get; init; }
    public string? PhoneExtension { get; init; }
    public string StreetAddress { get; init; }
    public string? SuiteApt { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string PostalCode { get; init; }
    
    public UserInformationType InformationType { get; init; }
    
    public string UserId { get; init; }
    public ApplicationUser User { get; init; }
}

public enum UserInformationType
{
    Contact, Owner
}