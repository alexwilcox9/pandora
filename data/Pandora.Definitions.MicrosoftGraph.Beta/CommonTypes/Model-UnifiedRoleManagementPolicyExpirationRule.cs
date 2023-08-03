// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class UnifiedRoleManagementPolicyExpirationRuleModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isExpirationRequired")]
    public bool? IsExpirationRequired { get; set; }

    [JsonPropertyName("maximumDuration")]
    public string? MaximumDuration { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("target")]
    public UnifiedRoleManagementPolicyRuleTargetModel? Target { get; set; }
}
