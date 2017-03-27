// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// External OAuth authorization server settings.
    /// </summary>
    public partial class OAuth2AuthorizationServerContract
    {
        private string _authorizationEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets OAuth authorization endpoint. See
        /// http://tools.ietf.org/html/rfc6749#section-3.2.
        /// </summary>
        public string AuthorizationEndpoint
        {
            get { return this._authorizationEndpoint; }
            set { this._authorizationEndpoint = value; }
        }
        
        private IList<MethodContract> _authorizationMethods;
        
        /// <summary>
        /// Optional. Gets or sets Supported methods of authorization.
        /// </summary>
        public IList<MethodContract> AuthorizationMethods
        {
            get { return this._authorizationMethods; }
            set { this._authorizationMethods = value; }
        }
        
        private IList<BearerTokenSendingMethodsContract> _bearerTokenSendingMethods;
        
        /// <summary>
        /// Optional. Gets or sets Form of an authorization grant, which the
        /// client uses to request the access token. See
        /// http://tools.ietf.org/html/rfc6749#section-4 .
        /// </summary>
        public IList<BearerTokenSendingMethodsContract> BearerTokenSendingMethods
        {
            get { return this._bearerTokenSendingMethods; }
            set { this._bearerTokenSendingMethods = value; }
        }
        
        private IList<ClientAuthenticationMethodContract> _clientAuthenticationMethod;
        
        /// <summary>
        /// Optional. Gets or sets Supported methods of authorization.
        /// </summary>
        public IList<ClientAuthenticationMethodContract> ClientAuthenticationMethod
        {
            get { return this._clientAuthenticationMethod; }
            set { this._clientAuthenticationMethod = value; }
        }
        
        private string _clientId;
        
        /// <summary>
        /// Optional. Gets or sets Client ID of developer console which is the
        /// client application.
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }
        
        private string _clientRegistrationEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets Client registration URI that will be shown
        /// for developers.
        /// </summary>
        public string ClientRegistrationEndpoint
        {
            get { return this._clientRegistrationEndpoint; }
            set { this._clientRegistrationEndpoint = value; }
        }
        
        private string _clientSecret;
        
        /// <summary>
        /// Optional. Gets or sets Client Secret of developer console which is
        /// the client application.
        /// </summary>
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }
        
        private string _defaultScope;
        
        /// <summary>
        /// Optional. Gets or sets Scope that is going to applied by default on
        /// the console page. See
        /// http://tools.ietf.org/html/rfc6749#section-3.3 .
        /// </summary>
        public string DefaultScope
        {
            get { return this._defaultScope; }
            set { this._defaultScope = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets User-friendly authorization server name.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IList<GrantTypesContract> _grantTypes;
        
        /// <summary>
        /// Optional. Gets or sets Form of an authorization grant, which the
        /// client uses to request the access token. See
        /// http://tools.ietf.org/html/rfc6749#section-4 .
        /// </summary>
        public IList<GrantTypesContract> GrantTypes
        {
            get { return this._grantTypes; }
            set { this._grantTypes = value; }
        }
        
        private string _idPath;
        
        /// <summary>
        /// Optional. Gets or sets Authorization server identifier path.
        /// </summary>
        public string IdPath
        {
            get { return this._idPath; }
            set { this._idPath = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets User-friendly authorization server name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _resourceOwnerPassword;
        
        /// <summary>
        /// Optional. Gets or sets Password of the resource owner on behalf of
        /// whom developer console will make requests.
        /// </summary>
        public string ResourceOwnerPassword
        {
            get { return this._resourceOwnerPassword; }
            set { this._resourceOwnerPassword = value; }
        }
        
        private string _resourceOwnerUsername;
        
        /// <summary>
        /// Optional. Gets or sets Username of the resource owner on behalf of
        /// whom developer console will make requests.
        /// </summary>
        public string ResourceOwnerUsername
        {
            get { return this._resourceOwnerUsername; }
            set { this._resourceOwnerUsername = value; }
        }
        
        private bool _supportState;
        
        /// <summary>
        /// Optional. Gets or sets whether Auhtorizatoin Server supports client
        /// credentials in body or not. See
        /// http://tools.ietf.org/html/rfc6749#section-3.1 .
        /// </summary>
        public bool SupportState
        {
            get { return this._supportState; }
            set { this._supportState = value; }
        }
        
        private IList<TokenBodyParameterContract> _tokenBodyParameters;
        
        /// <summary>
        /// Optional. Gets or sets Token request body parameters.
        /// </summary>
        public IList<TokenBodyParameterContract> TokenBodyParameters
        {
            get { return this._tokenBodyParameters; }
            set { this._tokenBodyParameters = value; }
        }
        
        private string _tokenEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets OAuth token endpoint. See
        /// http://tools.ietf.org/html/rfc6749#section-3.1 .
        /// </summary>
        public string TokenEndpoint
        {
            get { return this._tokenEndpoint; }
            set { this._tokenEndpoint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OAuth2AuthorizationServerContract
        /// class.
        /// </summary>
        public OAuth2AuthorizationServerContract()
        {
            this.AuthorizationMethods = new LazyList<MethodContract>();
            this.BearerTokenSendingMethods = new LazyList<BearerTokenSendingMethodsContract>();
            this.ClientAuthenticationMethod = new LazyList<ClientAuthenticationMethodContract>();
            this.GrantTypes = new LazyList<GrantTypesContract>();
            this.TokenBodyParameters = new LazyList<TokenBodyParameterContract>();
        }
    }
}