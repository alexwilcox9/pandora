// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class IosEnterpriseWiFiConfigurationModel
{
    [JsonPropertyName("assignments")]
    public List<DeviceConfigurationAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("authenticationMethod")]
    public WiFiAuthenticationMethodConstant? AuthenticationMethod { get; set; }

    [JsonPropertyName("connectAutomatically")]
    public bool? ConnectAutomatically { get; set; }

    [JsonPropertyName("connectWhenNetworkNameIsHidden")]
    public bool? ConnectWhenNetworkNameIsHidden { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("derivedCredentialSettings")]
    public DeviceManagementDerivedCredentialSettingsModel? DerivedCredentialSettings { get; set; }

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

    [JsonPropertyName("disableMacAddressRandomization")]
    public bool? DisableMacAddressRandomization { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("eapFastConfiguration")]
    public EapFastConfigurationConstant? EapFastConfiguration { get; set; }

    [JsonPropertyName("eapType")]
    public EapTypeConstant? EapType { get; set; }

    [JsonPropertyName("groupAssignments")]
    public List<DeviceConfigurationGroupAssignmentModel>? GroupAssignments { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("identityCertificateForClientAuthentication")]
    public IosCertificateProfileBaseModel? IdentityCertificateForClientAuthentication { get; set; }

    [JsonPropertyName("innerAuthenticationProtocolForEapTtls")]
    public NonEapAuthenticationMethodForEapTtlsTypeConstant? InnerAuthenticationProtocolForEapTtls { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("outerIdentityPrivacyTemporaryValue")]
    public string? OuterIdentityPrivacyTemporaryValue { get; set; }

    [JsonPropertyName("passwordFormatString")]
    public string? PasswordFormatString { get; set; }

    [JsonPropertyName("preSharedKey")]
    public string? PreSharedKey { get; set; }

    [JsonPropertyName("proxyAutomaticConfigurationUrl")]
    public string? ProxyAutomaticConfigurationUrl { get; set; }

    [JsonPropertyName("proxyManualAddress")]
    public string? ProxyManualAddress { get; set; }

    [JsonPropertyName("proxyManualPort")]
    public int? ProxyManualPort { get; set; }

    [JsonPropertyName("proxySettings")]
    public WiFiProxySettingConstant? ProxySettings { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("rootCertificatesForServerValidation")]
    public List<IosTrustedRootCertificateModel>? RootCertificatesForServerValidation { get; set; }

    [JsonPropertyName("ssid")]
    public string? Ssid { get; set; }

    [JsonPropertyName("supportsScopeTags")]
    public bool? SupportsScopeTags { get; set; }

    [JsonPropertyName("trustedServerCertificateNames")]
    public List<string>? TrustedServerCertificateNames { get; set; }

    [JsonPropertyName("userStatusOverview")]
    public DeviceConfigurationUserOverviewModel? UserStatusOverview { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<DeviceConfigurationUserStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("usernameFormatString")]
    public string? UsernameFormatString { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }

    [JsonPropertyName("wiFiSecurityType")]
    public WiFiSecurityTypeConstant? WiFiSecurityType { get; set; }
}
