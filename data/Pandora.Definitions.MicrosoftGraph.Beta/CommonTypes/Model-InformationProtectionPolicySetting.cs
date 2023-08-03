// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class InformationProtectionPolicySettingModel
{
    [JsonPropertyName("defaultLabelId")]
    public string? DefaultLabelId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isDowngradeJustificationRequired")]
    public bool? IsDowngradeJustificationRequired { get; set; }

    [JsonPropertyName("isMandatory")]
    public bool? IsMandatory { get; set; }

    [JsonPropertyName("moreInfoUrl")]
    public string? MoreInfoUrl { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
