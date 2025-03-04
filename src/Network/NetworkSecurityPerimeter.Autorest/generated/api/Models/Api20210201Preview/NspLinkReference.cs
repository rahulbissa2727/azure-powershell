// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    /// <summary>The network security perimeter linkReference resource</summary>
    public partial class NspLinkReference :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.ProxyResource();

        /// <summary>
        /// A message sent by the remote NSP link admin for connection request. In case of Auto-approved flow, it is default to 'Auto
        /// Approved'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).Description; }

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] LocalInboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).LocalInboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).LocalInboundProfile = value ?? null /* arrayOf */; }

        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. Use ['*'] to allow outbound from all profiles. It's default
        /// value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] LocalOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).LocalOutboundProfile; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).Description = value; }

        /// <summary>Internal Acessors for LocalOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.LocalOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).LocalOutboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).LocalOutboundProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkReferenceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RemoteInboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.RemoteInboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteInboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteInboundProfile = value; }

        /// <summary>Internal Acessors for RemoteOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.RemoteOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteOutboundProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteOutboundProfile = value; }

        /// <summary>Internal Acessors for RemotePerimeterGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.RemotePerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterGuid = value; }

        /// <summary>Internal Acessors for RemotePerimeterResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceInternal.RemotePerimeterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterResourceId = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Etag = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceProperties _property;

        /// <summary>Properties of the network security perimeter linkReference resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.NspLinkReferenceProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the NSP LinkReference resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. ['*'] value implies inbound is allowed to all profiles at remote
        /// perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] RemoteInboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteInboundProfile; }

        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. ['*'] value implies outbound is allowed from all profiles
        /// at remote perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string[] RemoteOutboundProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemoteOutboundProfile; }

        /// <summary>Remote NSP Guid with which the link is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string RemotePerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterGuid; }

        /// <summary>Perimeter ARM Id for the remote NSP with which the link is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public string RemotePerimeterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).RemotePerimeterResourceId; }

        /// <summary>
        /// The NSP linkReference state. It cannot be changed if link is created in auto-approval mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferencePropertiesInternal)Property).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus)""); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="NspLinkReference" /> instance.</summary>
        public NspLinkReference()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The network security perimeter linkReference resource
    public partial interface INspLinkReference :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResource
    {
        /// <summary>
        /// A message sent by the remote NSP link admin for connection request. In case of Auto-approved flow, it is default to 'Auto
        /// Approved'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A message sent by the remote NSP link admin for connection request. In case of Auto-approved flow, it is default to 'Auto Approved'.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value is ['*'].",
        SerializedName = @"localInboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocalInboundProfile { get; set; }
        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. Use ['*'] to allow outbound from all profiles. It's default
        /// value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Local Outbound profile names from which Outbound is allowed. Use ['*'] to allow outbound from all profiles. It's default value is ['*'].",
        SerializedName = @"localOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocalOutboundProfile { get;  }
        /// <summary>The provisioning state of the NSP LinkReference resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the NSP LinkReference resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. ['*'] value implies inbound is allowed to all profiles at remote
        /// perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote Inbound profile names to which Inbound is allowed. ['*'] value implies inbound is allowed to all profiles at remote perimeter. This property can only be updated from remote perimeter.",
        SerializedName = @"remoteInboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteInboundProfile { get;  }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. ['*'] value implies outbound is allowed from all profiles
        /// at remote perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote Outbound profile names from which Outbound is allowed. ['*'] value implies outbound is allowed from all profiles at remote perimeter. This property can only be updated from remote perimeter.",
        SerializedName = @"remoteOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteOutboundProfile { get;  }
        /// <summary>Remote NSP Guid with which the link is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote NSP Guid with which the link is created.",
        SerializedName = @"remotePerimeterGuid",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePerimeterGuid { get;  }
        /// <summary>Perimeter ARM Id for the remote NSP with which the link is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Perimeter ARM Id for the remote NSP with which the link is created.",
        SerializedName = @"remotePerimeterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePerimeterResourceId { get;  }
        /// <summary>
        /// The NSP linkReference state. It cannot be changed if link is created in auto-approval mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The NSP linkReference state. It cannot be changed if link is created in auto-approval mode.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get; set; }

    }
    /// The network security perimeter linkReference resource
    internal partial interface INspLinkReferenceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.IProxyResourceInternal
    {
        /// <summary>
        /// A message sent by the remote NSP link admin for connection request. In case of Auto-approved flow, it is default to 'Auto
        /// Approved'.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        string[] LocalInboundProfile { get; set; }
        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. Use ['*'] to allow outbound from all profiles. It's default
        /// value is ['*'].
        /// </summary>
        string[] LocalOutboundProfile { get; set; }
        /// <summary>Properties of the network security perimeter linkReference resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceProperties Property { get; set; }
        /// <summary>The provisioning state of the NSP LinkReference resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. ['*'] value implies inbound is allowed to all profiles at remote
        /// perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        string[] RemoteInboundProfile { get; set; }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. ['*'] value implies outbound is allowed from all profiles
        /// at remote perimeter. This property can only be updated from remote perimeter.
        /// </summary>
        string[] RemoteOutboundProfile { get; set; }
        /// <summary>Remote NSP Guid with which the link is created.</summary>
        string RemotePerimeterGuid { get; set; }
        /// <summary>Perimeter ARM Id for the remote NSP with which the link is created.</summary>
        string RemotePerimeterResourceId { get; set; }
        /// <summary>
        /// The NSP linkReference state. It cannot be changed if link is created in auto-approval mode.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get; set; }

    }
}