// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list NSP linkReference resources. Contains a list of NSP linkReference resources and a URL link
    /// to get the next set of results.
    /// </summary>
    public partial class NspLinkReferenceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReferenceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Gets the URL to get the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference[] _value;

        /// <summary>Gets a page of NSP LinkReference resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="NspLinkReferenceListResult" /> instance.</summary>
        public NspLinkReferenceListResult()
        {

        }
    }
    /// Result of the request to list NSP linkReference resources. Contains a list of NSP linkReference resources and a URL link
    /// to get the next set of results.
    public partial interface INspLinkReferenceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.IJsonSerializable
    {
        /// <summary>Gets the URL to get the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the URL to get the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Gets a page of NSP LinkReference resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets a page of NSP LinkReference resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference[] Value { get; set; }

    }
    /// Result of the request to list NSP linkReference resources. Contains a list of NSP linkReference resources and a URL link
    /// to get the next set of results.
    internal partial interface INspLinkReferenceListResultInternal

    {
        /// <summary>Gets the URL to get the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Gets a page of NSP LinkReference resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.Api20210201Preview.INspLinkReference[] Value { get; set; }

    }
}