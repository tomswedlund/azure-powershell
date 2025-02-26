namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Resolve health errors input properties.</summary>
    public partial class ResolveHealthError :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthErrorInternal
    {

        /// <summary>Backing field for <see cref="HealthErrorId" /> property.</summary>
        private string _healthErrorId;

        /// <summary>Health error id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string HealthErrorId { get => this._healthErrorId; set => this._healthErrorId = value; }

        /// <summary>Creates an new <see cref="ResolveHealthError" /> instance.</summary>
        public ResolveHealthError()
        {

        }
    }
    /// Resolve health errors input properties.
    public partial interface IResolveHealthError :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Health error id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health error id.",
        SerializedName = @"healthErrorId",
        PossibleTypes = new [] { typeof(string) })]
        string HealthErrorId { get; set; }

    }
    /// Resolve health errors input properties.
    internal partial interface IResolveHealthErrorInternal

    {
        /// <summary>Health error id.</summary>
        string HealthErrorId { get; set; }

    }
}