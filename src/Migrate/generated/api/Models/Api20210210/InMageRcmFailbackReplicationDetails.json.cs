namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcmFailback provider specific details.</summary>
    public partial class InMageRcmFailbackReplicationDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new InMageRcmFailbackReplicationDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="InMageRcmFailbackReplicationDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InMageRcmFailbackReplicationDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __replicationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificSettings(json);
            {_mobilityAgentDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("mobilityAgentDetails"), out var __jsonMobilityAgentDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackMobilityAgentDetails.FromJson(__jsonMobilityAgentDetails) : MobilityAgentDetail;}
            {_internalIdentifier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("internalIdentifier"), out var __jsonInternalIdentifier) ? (string)__jsonInternalIdentifier : (string)InternalIdentifier;}
            {_azureVirtualMachineId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("azureVirtualMachineId"), out var __jsonAzureVirtualMachineId) ? (string)__jsonAzureVirtualMachineId : (string)AzureVirtualMachineId;}
            {_multiVMGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupName"), out var __jsonMultiVMGroupName) ? (string)__jsonMultiVMGroupName : (string)MultiVMGroupName;}
            {_reprotectAgentId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("reprotectAgentId"), out var __jsonReprotectAgentId) ? (string)__jsonReprotectAgentId : (string)ReprotectAgentId;}
            {_reprotectAgentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("reprotectAgentName"), out var __jsonReprotectAgentName) ? (string)__jsonReprotectAgentName : (string)ReprotectAgentName;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_logStorageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("logStorageAccountId"), out var __jsonLogStorageAccountId) ? (string)__jsonLogStorageAccountId : (string)LogStorageAccountId;}
            {_targetvCenterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetvCenterId"), out var __jsonTargetvCenterId) ? (string)__jsonTargetvCenterId : (string)TargetvCenterId;}
            {_targetDataStoreName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetDataStoreName"), out var __jsonTargetDataStoreName) ? (string)__jsonTargetDataStoreName : (string)TargetDataStoreName;}
            {_targetVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetVmName"), out var __jsonTargetVMName) ? (string)__jsonTargetVMName : (string)TargetVMName;}
            {_initialReplicationProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("initialReplicationProgressPercentage"), out var __jsonInitialReplicationProgressPercentage) ? (int?)__jsonInitialReplicationProgressPercentage : InitialReplicationProgressPercentage;}
            {_initialReplicationProcessedByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("initialReplicationProcessedBytes"), out var __jsonInitialReplicationProcessedBytes) ? (long?)__jsonInitialReplicationProcessedBytes : InitialReplicationProcessedByte;}
            {_initialReplicationTransferredByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("initialReplicationTransferredBytes"), out var __jsonInitialReplicationTransferredBytes) ? (long?)__jsonInitialReplicationTransferredBytes : InitialReplicationTransferredByte;}
            {_initialReplicationProgressHealth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialReplicationProgressHealth"), out var __jsonInitialReplicationProgressHealth) ? (string)__jsonInitialReplicationProgressHealth : (string)InitialReplicationProgressHealth;}
            {_resyncProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resyncProgressPercentage"), out var __jsonResyncProgressPercentage) ? (int?)__jsonResyncProgressPercentage : ResyncProgressPercentage;}
            {_resyncProcessedByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resyncProcessedBytes"), out var __jsonResyncProcessedBytes) ? (long?)__jsonResyncProcessedBytes : ResyncProcessedByte;}
            {_resyncTransferredByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resyncTransferredBytes"), out var __jsonResyncTransferredBytes) ? (long?)__jsonResyncTransferredBytes : ResyncTransferredByte;}
            {_resyncProgressHealth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resyncProgressHealth"), out var __jsonResyncProgressHealth) ? (string)__jsonResyncProgressHealth : (string)ResyncProgressHealth;}
            {_resyncRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resyncRequired"), out var __jsonResyncRequired) ? (string)__jsonResyncRequired : (string)ResyncRequired;}
            {_resyncState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resyncState"), out var __jsonResyncState) ? (string)__jsonResyncState : (string)ResyncState;}
            {_protectedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("protectedDisks"), out var __jsonProtectedDisks) ? If( __jsonProtectedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetails.FromJson(__u) )) ))() : null : ProtectedDisk;}
            {_vMNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("vmNics"), out var __jsonVMNics) ? If( __jsonVMNics as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackNicDetails.FromJson(__p) )) ))() : null : VMNic;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InMageRcmFailbackReplicationDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InMageRcmFailbackReplicationDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __replicationProviderSpecificSettings?.ToJson(container, serializationMode);
            AddIf( null != this._mobilityAgentDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._mobilityAgentDetail.ToJson(null,serializationMode) : null, "mobilityAgentDetails" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._internalIdentifier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._internalIdentifier.ToString()) : null, "internalIdentifier" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._azureVirtualMachineId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._azureVirtualMachineId.ToString()) : null, "azureVirtualMachineId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._multiVMGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupName.ToString()) : null, "multiVmGroupName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._reprotectAgentId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._reprotectAgentId.ToString()) : null, "reprotectAgentId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._reprotectAgentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._reprotectAgentName.ToString()) : null, "reprotectAgentName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._logStorageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._logStorageAccountId.ToString()) : null, "logStorageAccountId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetvCenterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetvCenterId.ToString()) : null, "targetvCenterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetDataStoreName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetDataStoreName.ToString()) : null, "targetDataStoreName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetVMName.ToString()) : null, "targetVmName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._initialReplicationProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._initialReplicationProgressPercentage) : null, "initialReplicationProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._initialReplicationProcessedByte ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._initialReplicationProcessedByte) : null, "initialReplicationProcessedBytes" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._initialReplicationTransferredByte ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._initialReplicationTransferredByte) : null, "initialReplicationTransferredBytes" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._initialReplicationProgressHealth)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialReplicationProgressHealth.ToString()) : null, "initialReplicationProgressHealth" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resyncProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._resyncProgressPercentage) : null, "resyncProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resyncProcessedByte ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._resyncProcessedByte) : null, "resyncProcessedBytes" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resyncTransferredByte ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._resyncTransferredByte) : null, "resyncTransferredBytes" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resyncProgressHealth)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resyncProgressHealth.ToString()) : null, "resyncProgressHealth" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resyncRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resyncRequired.ToString()) : null, "resyncRequired" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resyncState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resyncState.ToString()) : null, "resyncState" ,container.Add );
            }
            if (null != this._protectedDisk)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._protectedDisk )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("protectedDisks",__w);
            }
            if (null != this._vMNic)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __s in this._vMNic )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("vmNics",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}