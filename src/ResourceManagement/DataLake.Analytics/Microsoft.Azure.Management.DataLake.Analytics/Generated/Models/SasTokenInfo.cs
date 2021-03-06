// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// SAS token information.
    /// </summary>
    public partial class SasTokenInfo
    {
        /// <summary>
        /// Initializes a new instance of the SasTokenInfo class.
        /// </summary>
        public SasTokenInfo() { }

        /// <summary>
        /// Initializes a new instance of the SasTokenInfo class.
        /// </summary>
        /// <param name="accessToken">the access token for the associated Azure Storage Container.</param>
        public SasTokenInfo(string accessToken = default(string))
        {
            AccessToken = accessToken;
        }

        /// <summary>
        /// Gets the access token for the associated Azure Storage Container.
        /// </summary>
        [JsonProperty(PropertyName = "accessToken")]
        public string AccessToken { get; private set; }

    }
}
