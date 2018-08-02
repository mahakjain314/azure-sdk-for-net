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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Service Principal operation response.
    /// </summary>
    public partial class SubscriptionServicePrincipalListResponse : AzureOperationResponse, IEnumerable<SubscriptionServicePrincipalListResponse.ServicePrincipal>
    {
        private IList<SubscriptionServicePrincipalListResponse.ServicePrincipal> _servicePrincipals;
        
        /// <summary>
        /// Optional. The service principals existing in the subscription.
        /// </summary>
        public IList<SubscriptionServicePrincipalListResponse.ServicePrincipal> ServicePrincipals
        {
            get { return this._servicePrincipals; }
            set { this._servicePrincipals = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionServicePrincipalListResponse class.
        /// </summary>
        public SubscriptionServicePrincipalListResponse()
        {
            this.ServicePrincipals = new LazyList<SubscriptionServicePrincipalListResponse.ServicePrincipal>();
        }
        
        /// <summary>
        /// Gets the sequence of ServicePrincipals.
        /// </summary>
        public IEnumerator<SubscriptionServicePrincipalListResponse.ServicePrincipal> GetEnumerator()
        {
            return this.ServicePrincipals.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ServicePrincipals.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A service principal existing in the subscription.
        /// </summary>
        public partial class ServicePrincipal
        {
            private string _description;
            
            /// <summary>
            /// Optional. The description of the service principal.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private IDictionary<string, string> _extendedProperties;
            
            /// <summary>
            /// Optional. Represents the name of an extended service principal
            /// property. Each extended property must have a defined name and
            /// a value. You can have a maximum of 25 extended property
            /// name/value pairs. The maximum length of the name element is 64
            /// characters, only alphanumeric characters and underscores are
            /// valid in the name, and the name must start with a letter.
            /// Attempting to use other characters, starting the name with a
            /// non-letter character, or entering a name that is identical to
            /// that of another extended property owned by the same hosted
            /// service will result in a status code 400 (Bad Request) error.
            /// </summary>
            public IDictionary<string, string> ExtendedProperties
            {
                get { return this._extendedProperties; }
                set { this._extendedProperties = value; }
            }
            
            private string _servicePrincipalId;
            
            /// <summary>
            /// Optional. The ObjectId of Service Principal to add.
            /// </summary>
            public string ServicePrincipalId
            {
                get { return this._servicePrincipalId; }
                set { this._servicePrincipalId = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ServicePrincipal class.
            /// </summary>
            public ServicePrincipal()
            {
                this.ExtendedProperties = new LazyDictionary<string, string>();
            }
        }
    }
}
