namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Hyper V VM network details.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMNicDetailsTypeConverter))]
    public partial class VMNicDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMNicDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMNicDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMNicDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMNicDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).NicId = (string) content.GetValueForProperty("NicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).NicId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReplicaNicId = (string) content.GetValueForProperty("ReplicaNicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReplicaNicId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SourceNicArmId = (string) content.GetValueForProperty("SourceNicArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SourceNicArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).VMNetworkName = (string) content.GetValueForProperty("VMNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).VMNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryVMNetworkId = (string) content.GetValueForProperty("RecoveryVMNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryVMNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).IPConfig = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails[]) content.GetValueForProperty("IPConfig",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).IPConfig, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SelectionType = (string) content.GetValueForProperty("SelectionType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SelectionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNetworkSecurityGroupId = (string) content.GetValueForProperty("RecoveryNetworkSecurityGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNetworkSecurityGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnRecovery = (bool?) content.GetValueForProperty("EnableAcceleratedNetworkingOnRecovery",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnRecovery, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoVMNetworkId = (string) content.GetValueForProperty("TfoVMNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoVMNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoNetworkSecurityGroupId = (string) content.GetValueForProperty("TfoNetworkSecurityGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoNetworkSecurityGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnTfo = (bool?) content.GetValueForProperty("EnableAcceleratedNetworkingOnTfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnTfo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicName = (string) content.GetValueForProperty("RecoveryNicName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicResourceGroupName = (string) content.GetValueForProperty("RecoveryNicResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReuseExistingNic = (bool?) content.GetValueForProperty("ReuseExistingNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReuseExistingNic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicName = (string) content.GetValueForProperty("TfoRecoveryNicName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicResourceGroupName = (string) content.GetValueForProperty("TfoRecoveryNicResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoReuseExistingNic = (bool?) content.GetValueForProperty("TfoReuseExistingNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoReuseExistingNic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMNicDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).NicId = (string) content.GetValueForProperty("NicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).NicId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReplicaNicId = (string) content.GetValueForProperty("ReplicaNicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReplicaNicId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SourceNicArmId = (string) content.GetValueForProperty("SourceNicArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SourceNicArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).VMNetworkName = (string) content.GetValueForProperty("VMNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).VMNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryVMNetworkId = (string) content.GetValueForProperty("RecoveryVMNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryVMNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).IPConfig = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails[]) content.GetValueForProperty("IPConfig",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).IPConfig, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SelectionType = (string) content.GetValueForProperty("SelectionType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).SelectionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNetworkSecurityGroupId = (string) content.GetValueForProperty("RecoveryNetworkSecurityGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNetworkSecurityGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnRecovery = (bool?) content.GetValueForProperty("EnableAcceleratedNetworkingOnRecovery",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnRecovery, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoVMNetworkId = (string) content.GetValueForProperty("TfoVMNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoVMNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoNetworkSecurityGroupId = (string) content.GetValueForProperty("TfoNetworkSecurityGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoNetworkSecurityGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnTfo = (bool?) content.GetValueForProperty("EnableAcceleratedNetworkingOnTfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).EnableAcceleratedNetworkingOnTfo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicName = (string) content.GetValueForProperty("RecoveryNicName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicResourceGroupName = (string) content.GetValueForProperty("RecoveryNicResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).RecoveryNicResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReuseExistingNic = (bool?) content.GetValueForProperty("ReuseExistingNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).ReuseExistingNic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicName = (string) content.GetValueForProperty("TfoRecoveryNicName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicResourceGroupName = (string) content.GetValueForProperty("TfoRecoveryNicResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoRecoveryNicResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoReuseExistingNic = (bool?) content.GetValueForProperty("TfoReuseExistingNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetailsInternal)this).TfoReuseExistingNic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// Hyper V VM network details.
    [System.ComponentModel.TypeConverter(typeof(VMNicDetailsTypeConverter))]
    public partial interface IVMNicDetails

    {

    }
}