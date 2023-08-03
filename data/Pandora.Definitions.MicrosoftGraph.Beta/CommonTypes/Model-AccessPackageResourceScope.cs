// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AccessPackageResourceScopeModel
{
    [JsonPropertyName("accessPackageResource")]
    public AccessPackageResourceModel? AccessPackageResource { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isRootScope")]
    public bool? IsRootScope { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    [JsonPropertyName("originSystem")]
    public string? OriginSystem { get; set; }

    [JsonPropertyName("roleOriginId")]
    public string? RoleOriginId { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
