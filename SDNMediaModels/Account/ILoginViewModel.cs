namespace SDNMediaModels.Account
{
    public interface ILoginViewModel
    {
        string Password { get; set; }
        bool RememberMe { get; set; }
        string UserName { get; set; }
    }
}