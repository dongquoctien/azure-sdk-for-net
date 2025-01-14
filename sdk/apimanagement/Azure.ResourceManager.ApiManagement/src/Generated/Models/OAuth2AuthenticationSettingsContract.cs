// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API OAuth2 Authentication settings details. </summary>
    public partial class OAuth2AuthenticationSettingsContract
    {
        /// <summary> Initializes a new instance of OAuth2AuthenticationSettingsContract. </summary>
        public OAuth2AuthenticationSettingsContract()
        {
        }

        /// <summary> Initializes a new instance of OAuth2AuthenticationSettingsContract. </summary>
        /// <param name="authorizationServerId"> OAuth authorization server identifier. </param>
        /// <param name="scope"> operations scope. </param>
        internal OAuth2AuthenticationSettingsContract(string authorizationServerId, string scope)
        {
            AuthorizationServerId = authorizationServerId;
            Scope = scope;
        }

        /// <summary> OAuth authorization server identifier. </summary>
        public string AuthorizationServerId { get; set; }
        /// <summary> operations scope. </summary>
        public string Scope { get; set; }
    }
}
