namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Request to failover a process server.</summary>
    [System.ComponentModel.TypeConverter(typeof(FailoverProcessServerRequestTypeConverter))]
    public partial class FailoverProcessServerRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FailoverProcessServerRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FailoverProcessServerRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FailoverProcessServerRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequestPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).ContainerName = (string) content.GetValueForProperty("ContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).ContainerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).SourceProcessServerId = (string) content.GetValueForProperty("SourceProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).SourceProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).TargetProcessServerId = (string) content.GetValueForProperty("TargetProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).TargetProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).VmsToMigrate = (string[]) content.GetValueForProperty("VmsToMigrate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).VmsToMigrate, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).UpdateType = (string) content.GetValueForProperty("UpdateType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).UpdateType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FailoverProcessServerRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FailoverProcessServerRequestPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).ContainerName = (string) content.GetValueForProperty("ContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).ContainerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).SourceProcessServerId = (string) content.GetValueForProperty("SourceProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).SourceProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).TargetProcessServerId = (string) content.GetValueForProperty("TargetProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).TargetProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).VmsToMigrate = (string[]) content.GetValueForProperty("VmsToMigrate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).VmsToMigrate, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).UpdateType = (string) content.GetValueForProperty("UpdateType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequestInternal)this).UpdateType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FailoverProcessServerRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFailoverProcessServerRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Request to failover a process server.
    [System.ComponentModel.TypeConverter(typeof(FailoverProcessServerRequestTypeConverter))]
    public partial interface IFailoverProcessServerRequest

    {

    }
}