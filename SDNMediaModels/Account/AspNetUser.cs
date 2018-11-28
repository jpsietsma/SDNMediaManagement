using Microsoft.AspNet.Identity.EntityFramework;
using SDNMediaModels.Api;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;


namespace SDNMediaModels.Account
{    
    
    public partial class AspNetUser : IAspNetUser
    {

        public AspNetUser()
        {
            this.ApiTokens = new HashSet<ApiToken>();
            this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.UserRequests = new HashSet<UserRequest>();
            this.TaskQueues = new HashSet<TaskQueue>();
            this.AspNetRoles = new HashSet<AspNetRole>();
        }
    
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZipcode { get; set; }
        public int AllowAccess { get; set; }
    
        
        public virtual ICollection<ApiToken> ApiTokens { get; set; }        
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }        
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }        
        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }       
        public virtual ICollection<UserRequest> UserRequests { get; set; }        
        public virtual ICollection<TaskQueue> TaskQueues { get; set; }        
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
        public virtual ICollection<TrackedShow> TrackedShows { get; set; }
		
    }
}
