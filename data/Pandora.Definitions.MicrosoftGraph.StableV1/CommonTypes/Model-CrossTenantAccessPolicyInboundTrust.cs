// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class CrossTenantAccessPolicyInboundTrustModel
{
    [JsonPropertyName("isCompliantDeviceAccepted")]
    public bool? IsCompliantDeviceAccepted { get; set; }

    [JsonPropertyName("isHybridAzureADJoinedDeviceAccepted")]
    public bool? IsHybridAzureADJoinedDeviceAccepted { get; set; }

    [JsonPropertyName("isMfaAccepted")]
    public bool? IsMfaAccepted { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
