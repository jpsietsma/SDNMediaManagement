namespace SDNMediaModels.Account
{
    public interface IAspNetUserClaim
    {
        AspNetUser AspNetUser { get; set; }
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
        int Id { get; set; }
        string UserId { get; set; }
    }
}