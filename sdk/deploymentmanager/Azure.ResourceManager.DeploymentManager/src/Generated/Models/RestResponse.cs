// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> The properties that make up the expected REST response. </summary>
    public partial class RestResponse
    {
        /// <summary> Initializes a new instance of RestResponse. </summary>
        public RestResponse()
        {
            SuccessStatusCodes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RestResponse. </summary>
        /// <param name="successStatusCodes"> The HTTP status codes expected in a successful health check response. The response is expected to match one of the given status codes. If no expected status codes are provided, default expected status code is 200 OK. </param>
        /// <param name="regex"> The regular expressions to match the response content with. </param>
        internal RestResponse(IList<string> successStatusCodes, RestResponseRegex regex)
        {
            SuccessStatusCodes = successStatusCodes;
            Regex = regex;
        }

        /// <summary> The HTTP status codes expected in a successful health check response. The response is expected to match one of the given status codes. If no expected status codes are provided, default expected status code is 200 OK. </summary>
        public IList<string> SuccessStatusCodes { get; }
        /// <summary> The regular expressions to match the response content with. </summary>
        public RestResponseRegex Regex { get; set; }
    }
}
