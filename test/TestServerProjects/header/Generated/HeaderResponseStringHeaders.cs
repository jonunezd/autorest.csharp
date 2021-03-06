// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace header
{
    internal class HeaderResponseStringHeaders
    {
        private readonly Response _response;
        public HeaderResponseStringHeaders(Response response)
        {
            _response = response;
        }
        public string Value => _response.Headers.TryGetValue("value", out string value) ? value : null;
    }
}
