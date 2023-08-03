// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ControlScoreModel
{
    [JsonPropertyName("controlCategory")]
    public string? ControlCategory { get; set; }

    [JsonPropertyName("controlName")]
    public string? ControlName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
