//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MevzuatOrg.Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class aspnet_Users
    {
        public aspnet_Users()
        {
            this.aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
            this.Haberler = new HashSet<Haberler>();
            this.Makaleler = new HashSet<Makaleler>();
            this.aspnet_Roles = new HashSet<aspnet_Roles>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public System.DateTime LastActivityDate { get; set; }
    
        public virtual aspnet_Applications aspnet_Applications { get; set; }
        public virtual aspnet_Membership aspnet_Membership { get; set; }
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual aspnet_Profile aspnet_Profile { get; set; }
        public virtual ICollection<Haberler> Haberler { get; set; }
        public virtual ICollection<Makaleler> Makaleler { get; set; }
        public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }
    }
}
