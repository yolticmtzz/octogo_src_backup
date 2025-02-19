﻿using CF.Octogo.UiCustomization.Dto;

namespace CF.Octogo.Sessions.Dto
{
    public class GetCurrentLoginInformationsOutput
    {
        public UserLoginInfoDto User { get; set; }
        
        public UserLoginInfoDto ImpersonatorUser { get; set; }

        public TenantLoginInfoDto Tenant { get; set; }
        
        public TenantLoginInfoDto ImpersonatorTenant { get; set; }

        public ApplicationInfoDto Application { get; set; }

        public UiCustomizationSettingsDto Theme { get; set; }
    }
    public class GetCurrentLoginInformationsOutputNew
    {
        public UserLoginInfoNewDto User { get; set; }

        public UserLoginInfoDto ImpersonatorUser { get; set; }

        public TenantLoginInfoDto Tenant { get; set; }

        public TenantLoginInfoDto ImpersonatorTenant { get; set; }

        public ApplicationInfoDto Application { get; set; }

        public UiCustomizationSettingsDto Theme { get; set; }
    }
}