// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class PrintTaskModel
{
    [JsonPropertyName("definition")]
    public PrintTaskDefinitionModel? Definition { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("parentUrl")]
    public string? ParentUrl { get; set; }

    [JsonPropertyName("status")]
    public PrintTaskStatusModel? Status { get; set; }

    [JsonPropertyName("trigger")]
    public PrintTaskTriggerModel? Trigger { get; set; }
}
