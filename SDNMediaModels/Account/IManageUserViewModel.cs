namespace SDNMediaModels.Account
{
    public interface IManageUserViewModel
    {
        string ConfirmPassword { get; set; }
        string NewPassword { get; set; }
        string OldPassword { get; set; }
    }
}