// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class DriveItemUploadablePropertiesModel
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("fileSize")]
    public long? FileSize { get; set; }

    [JsonPropertyName("fileSystemInfo")]
    public FileSystemInfoModel? FileSystemInfo { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
