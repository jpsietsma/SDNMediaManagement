namespace SDNMediaModels.Account
{
    public interface IAspNetUserLogin
    {
        AspNetUser AspNetUser { get; set; }
        string LoginProvider { get; set; }
        string ProviderKey { get; set; }
        string UserId { get; set; }
    }
}