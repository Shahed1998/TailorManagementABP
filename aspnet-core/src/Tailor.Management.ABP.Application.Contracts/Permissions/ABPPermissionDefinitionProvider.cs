﻿using Tailor.Management.ABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tailor.Management.ABP.Permissions
{
    public class ABPPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var TailorManagementGroup = context.AddGroup(ABPPermissions.GroupName);
            //Define your own permissions here. Example:
            //TailorManagementGroup.AddPermission(ABPPermissions./*/*MyPermission1*/*/, L("Permission:MyPermission1"));
            var tailorModules = context.AddGroup("Tailor Modules"); // create a module name
            tailorModules.AddPermission("Admin");
            tailorModules.AddPermission("Customer");
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ABPResource>(name);
        }
    }
}
