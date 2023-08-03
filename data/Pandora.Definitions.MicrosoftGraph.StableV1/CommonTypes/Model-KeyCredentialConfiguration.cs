// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class KeyCredentialConfigurationModel
{
    [JsonPropertyName("maxLifetime")]
    public string? MaxLifetime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("restrictForAppsCreatedAfterDateTime")]
    public DateTime? RestrictForAppsCreatedAfterDateTime { get; set; }

    [JsonPropertyName("restrictionType")]
    public AppKeyCredentialRestrictionTypeConstant? RestrictionType { get; set; }
}
