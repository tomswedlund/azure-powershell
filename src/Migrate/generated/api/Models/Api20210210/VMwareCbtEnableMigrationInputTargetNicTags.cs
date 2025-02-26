namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the target NICs.</summary>
    public partial class VMwareCbtEnableMigrationInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputTargetNicTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="VMwareCbtEnableMigrationInputTargetNicTags" /> instance.
        /// </summary>
        public VMwareCbtEnableMigrationInputTargetNicTags()
        {

        }
    }
    /// The tags for the target NICs.
    public partial interface IVMwareCbtEnableMigrationInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the target NICs.
    internal partial interface IVMwareCbtEnableMigrationInputTargetNicTagsInternal

    {

    }
}