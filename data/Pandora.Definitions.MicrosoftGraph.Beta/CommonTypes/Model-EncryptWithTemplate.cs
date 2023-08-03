// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class EncryptWithTemplateModel
{
    [JsonPropertyName("availableForEncryption")]
    public bool? AvailableForEncryption { get; set; }

    [JsonPropertyName("encryptWith")]
    public EncryptWithConstant? EncryptWith { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}
