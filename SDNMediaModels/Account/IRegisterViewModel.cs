namespace SDNMediaModels.Account
{
    public interface IRegisterViewModel
    {
        string ConfirmPassword { get; set; }
        string Password { get; set; }
        string UserName { get; set; }
        string UserRoles { get; set; }
    }
}