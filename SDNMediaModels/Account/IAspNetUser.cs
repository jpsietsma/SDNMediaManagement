using System;
using System.Collections.Generic;
using SDNMediaModels.Api;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;

namespace SDNMediaModels.Account
{
    public interface IAspNetUser
    {
        int AccessFailedCount { get; set; }
        string AddressCity { get; set; }
        string AddressState { get; set; }
        string AddressStreet { get; set; }
        string AddressZipcode { get; set; }
        int AllowAccess { get; set; }
        ICollection<ApiToken> ApiTokens { get; set; }
        ICollection<AspNetRole> AspNetRoles { get; set; }
        ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        string Email { get; set; }
        bool EmailConfirmed { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        bool LockoutEnabled { get; set; }
        DateTime? LockoutEndDateUtc { get; set; }
        string PasswordHash { get; set; }
        string PhoneNumber { get; set; }
        bool PhoneNumberConfirmed { get; set; }
        ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        string SecurityStamp { get; set; }
        ICollection<TaskQueue> TaskQueues { get; set; }
        bool TwoFactorEnabled { get; set; }
        string UserName { get; set; }
        ICollection<UserRequest> UserRequests { get; set; }
    }
}