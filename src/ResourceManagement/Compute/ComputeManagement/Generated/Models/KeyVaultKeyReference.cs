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
using System.Linq;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a reference to Key Vault Key
    /// </summary>
    public partial class KeyVaultKeyReference
    {
        private string _keyUrl;
        
        /// <summary>
        /// Required. Gets or sets the URL referencing a key in a Key Vault.
        /// </summary>
        public string KeyUrl
        {
            get { return this._keyUrl; }
            set { this._keyUrl = value; }
        }
        
        private SourceVaultReference _sourceVault;
        
        /// <summary>
        /// Required. Gets or sets the Relative URL of the Key Vault containing
        /// the key
        /// </summary>
        public SourceVaultReference SourceVault
        {
            get { return this._sourceVault; }
            set { this._sourceVault = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class.
        /// </summary>
        public KeyVaultKeyReference()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class with
        /// required arguments.
        /// </summary>
        public KeyVaultKeyReference(string keyUrl, SourceVaultReference sourceVault)
            : this()
        {
            if (keyUrl == null)
            {
                throw new ArgumentNullException("keyUrl");
            }
            if (sourceVault == null)
            {
                throw new ArgumentNullException("sourceVault");
            }
            this.KeyUrl = keyUrl;
            this.SourceVault = sourceVault;
        }
    }
}
