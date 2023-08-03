// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class WindowsPhone81VpnConfigurationModel
{
    [JsonPropertyName("applyOnlyToWindows81")]
    public bool? ApplyOnlyToWindows81 { get; set; }

    [JsonPropertyName("assignments")]
    public List<DeviceConfigurationAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("authenticationMethod")]
    public VpnAuthenticationMethodConstant? AuthenticationMethod { get; set; }

    [JsonPropertyName("bypassVpnOnCompanyWifi")]
    public bool? BypassVpnOnCompanyWifi { get; set; }

    [JsonPropertyName("bypassVpnOnHomeWifi")]
    public bool? BypassVpnOnHomeWifi { get; set; }

    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    [JsonPropertyName("connectionType")]
    public WindowsVpnConnectionTypeConstant? ConnectionType { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("customXml")]
    public string? CustomXml { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleDeviceMode")]
    public DeviceManagementApplicabilityRuleDeviceModeModel? DeviceManagementApplicabilityRuleDeviceMode { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleOsEdition")]
    public DeviceManagementApplicabilityRuleOsEditionModel? DeviceManagementApplicabilityRuleOsEdition { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleOsVersion")]
    public DeviceManagementApplicabilityRuleOsVersionModel? DeviceManagementApplicabilityRuleOsVersion { get; set; }

    [JsonPropertyName("deviceSettingStateSummaries")]
    public List<SettingStateDeviceSummaryModel>? DeviceSettingStateSummaries { get; set; }

    [JsonPropertyName("deviceStatusOverview")]
    public DeviceConfigurationDeviceOverviewModel? DeviceStatusOverview { get; set; }

    [JsonPropertyName("deviceStatuses")]
    public List<DeviceConfigurationDeviceStatusModel>? DeviceStatuses { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("dnsSuffixSearchList")]
    public List<string>? DnsSuffixSearchList { get; set; }

    [JsonPropertyName("enableSplitTunneling")]
    public bool? EnableSplitTunneling { get; set; }

    [JsonPropertyName("groupAssignments")]
    public List<DeviceConfigurationGroupAssignmentModel>? GroupAssignments { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("identityCertificate")]
    public WindowsPhone81CertificateProfileBaseModel? IdentityCertificate { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("loginGroupOrDomain")]
    public string? LoginGroupOrDomain { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("proxyServer")]
    public Windows81VpnProxyServerModel? ProxyServer { get; set; }

    [JsonPropertyName("rememberUserCredentials")]
    public bool? RememberUserCredentials { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("servers")]
    public List<VpnServerModel>? Servers { get; set; }

    [JsonPropertyName("supportsScopeTags")]
    public bool? SupportsScopeTags { get; set; }

    [JsonPropertyName("userStatusOverview")]
    public DeviceConfigurationUserOverviewModel? UserStatusOverview { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<DeviceConfigurationUserStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }
}
