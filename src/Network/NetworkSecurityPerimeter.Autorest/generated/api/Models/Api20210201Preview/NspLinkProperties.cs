// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    /// <summary>Properties of NSP Link resource.</summary>
    public partial class NspLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal
    {

        /// <summary>
        /// Backing field for <see cref="AutoApprovedRemotePerimeterResourceId" /> property.
        /// </summary>
        private string _autoApprovedRemotePerimeterResourceId;

        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string AutoApprovedRemotePerimeterResourceId { get => this._autoApprovedRemotePerimeterResourceId; set => this._autoApprovedRemotePerimeterResourceId = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="LocalInboundProfile" /> property.</summary>
        private string[] _localInboundProfile;

        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string[] LocalInboundProfile { get => this._localInboundProfile; set => this._localInboundProfile = value; }

        /// <summary>Backing field for <see cref="LocalOutboundProfile" /> property.</summary>
        private string[] _localOutboundProfile;

        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string[] LocalOutboundProfile { get => this._localOutboundProfile; }

        /// <summary>Internal Acessors for LocalOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal.LocalOutboundProfile { get => this._localOutboundProfile; set { {_localOutboundProfile = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RemoteOutboundProfile</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal.RemoteOutboundProfile { get => this._remoteOutboundProfile; set { {_remoteOutboundProfile = value;} } }

        /// <summary>Internal Acessors for RemotePerimeterGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal.RemotePerimeterGuid { get => this._remotePerimeterGuid; set { {_remotePerimeterGuid = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the NSP Link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RemoteInboundProfile" /> property.</summary>
        private string[] _remoteInboundProfile;

        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string[] RemoteInboundProfile { get => this._remoteInboundProfile; set => this._remoteInboundProfile = value; }

        /// <summary>Backing field for <see cref="RemoteOutboundProfile" /> property.</summary>
        private string[] _remoteOutboundProfile;

        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string[] RemoteOutboundProfile { get => this._remoteOutboundProfile; }

        /// <summary>Backing field for <see cref="RemotePerimeterGuid" /> property.</summary>
        private string _remotePerimeterGuid;

        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string RemotePerimeterGuid { get => this._remotePerimeterGuid; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? _status;

        /// <summary>The NSP link state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="NspLinkProperties" /> instance.</summary>
        public NspLinkProperties()
        {

        }
    }
    /// Properties of NSP Link resource.
    public partial interface INspLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.",
        SerializedName = @"autoApprovedRemotePerimeterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AutoApprovedRemotePerimeterResourceId { get; set; }
        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow, it is default to 'Auto Approved'. Restricted to 140 chars.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
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
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.",
        SerializedName = @"localOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocalOutboundProfile { get;  }
        /// <summary>The provisioning state of the NSP Link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the NSP Link resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can only be updated in auto-approval mode. It's default value is ['*'].",
        SerializedName = @"remoteInboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteInboundProfile { get; set; }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.",
        SerializedName = @"remoteOutboundProfiles",
        PossibleTypes = new [] { typeof(string) })]
        string[] RemoteOutboundProfile { get;  }
        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remote NSP Guid with which the link gets created.",
        SerializedName = @"remotePerimeterGuid",
        PossibleTypes = new [] { typeof(string) })]
        string RemotePerimeterGuid { get;  }
        /// <summary>The NSP link state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The NSP link state.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get;  }

    }
    /// Properties of NSP Link resource.
    internal partial interface INspLinkPropertiesInternal

    {
        /// <summary>
        /// Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the
        /// NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource.
        /// </summary>
        string AutoApprovedRemotePerimeterResourceId { get; set; }
        /// <summary>
        /// A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow,
        /// it is default to 'Auto Approved'. Restricted to 140 chars.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. It's default value
        /// is ['*'].
        /// </summary>
        string[] LocalInboundProfile { get; set; }
        /// <summary>
        /// Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        string[] LocalOutboundProfile { get; set; }
        /// <summary>The provisioning state of the NSP Link resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can
        /// only be updated in auto-approval mode. It's default value is ['*'].
        /// </summary>
        string[] RemoteInboundProfile { get; set; }
        /// <summary>
        /// Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value
        /// is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it.
        /// </summary>
        string[] RemoteOutboundProfile { get; set; }
        /// <summary>Remote NSP Guid with which the link gets created.</summary>
        string RemotePerimeterGuid { get; set; }
        /// <summary>The NSP link state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Support.NspLinkStatus? Status { get; set; }

    }
}