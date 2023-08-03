// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class DeviceManagementExchangeOnPremisesPolicyModel
{
    [JsonPropertyName("accessRules")]
    public List<DeviceManagementExchangeAccessRuleModel>? AccessRules { get; set; }

    [JsonPropertyName("conditionalAccessSettings")]
    public OnPremisesConditionalAccessSettingsModel? ConditionalAccessSettings { get; set; }

    [JsonPropertyName("defaultAccessLevel")]
    public DeviceManagementExchangeAccessLevelConstant? DefaultAccessLevel { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("knownDeviceClasses")]
    public List<DeviceManagementExchangeDeviceClassModel>? KnownDeviceClasses { get; set; }

    [JsonPropertyName("notificationContent")]
    public string? NotificationContent { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
