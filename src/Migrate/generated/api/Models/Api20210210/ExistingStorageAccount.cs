namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Existing storage account input.</summary>
    public partial class ExistingStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingStorageAccount,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingStorageAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails __storageAccountCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails();

        /// <summary>Backing field for <see cref="AzureStorageAccountId" /> property.</summary>
        private string _azureStorageAccountId;

        /// <summary>The storage account Arm Id. Throw error, if resource does not exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AzureStorageAccountId { get => this._azureStorageAccountId; set => this._azureStorageAccountId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)__storageAccountCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)__storageAccountCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="ExistingStorageAccount" /> instance.</summary>
        public ExistingStorageAccount()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__storageAccountCustomDetails), __storageAccountCustomDetails);
            await eventListener.AssertObjectIsValid(nameof(__storageAccountCustomDetails), __storageAccountCustomDetails);
        }
    }
    /// Existing storage account input.
    public partial interface IExistingStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails
    {
        /// <summary>The storage account Arm Id. Throw error, if resource does not exists.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The storage account Arm Id. Throw error, if resource does not exists.",
        SerializedName = @"azureStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureStorageAccountId { get; set; }

    }
    /// Existing storage account input.
    internal partial interface IExistingStorageAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal
    {
        /// <summary>The storage account Arm Id. Throw error, if resource does not exists.</summary>
        string AzureStorageAccountId { get; set; }

    }
}