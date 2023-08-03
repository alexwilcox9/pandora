// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionModel
{
    [JsonPropertyName("activeDeviceCount")]
    public int? ActiveDeviceCount { get; set; }

    [JsonPropertyName("appCrashCount")]
    public int? AppCrashCount { get; set; }

    [JsonPropertyName("appDisplayName")]
    public string? AppDisplayName { get; set; }

    [JsonPropertyName("appName")]
    public string? AppName { get; set; }

    [JsonPropertyName("appPublisher")]
    public string? AppPublisher { get; set; }

    [JsonPropertyName("appUsageDuration")]
    public int? AppUsageDuration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("meanTimeToFailureInMinutes")]
    public int? MeanTimeToFailureInMinutes { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("osBuildNumber")]
    public string? OsBuildNumber { get; set; }

    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }
}
