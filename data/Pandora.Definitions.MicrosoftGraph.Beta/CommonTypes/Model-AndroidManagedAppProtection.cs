// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AndroidManagedAppProtectionModel
{
    [JsonPropertyName("allowedAndroidDeviceManufacturers")]
    public string? AllowedAndroidDeviceManufacturers { get; set; }

    [JsonPropertyName("allowedAndroidDeviceModels")]
    public List<string>? AllowedAndroidDeviceModels { get; set; }

    [JsonPropertyName("allowedDataIngestionLocations")]
    public List<ManagedAppDataIngestionLocationConstant>? AllowedDataIngestionLocations { get; set; }

    [JsonPropertyName("allowedDataStorageLocations")]
    public List<ManagedAppDataStorageLocationConstant>? AllowedDataStorageLocations { get; set; }

    [JsonPropertyName("allowedInboundDataTransferSources")]
    public ManagedAppDataTransferLevelConstant? AllowedInboundDataTransferSources { get; set; }

    [JsonPropertyName("allowedOutboundClipboardSharingExceptionLength")]
    public int? AllowedOutboundClipboardSharingExceptionLength { get; set; }

    [JsonPropertyName("allowedOutboundClipboardSharingLevel")]
    public ManagedAppClipboardSharingLevelConstant? AllowedOutboundClipboardSharingLevel { get; set; }

    [JsonPropertyName("allowedOutboundDataTransferDestinations")]
    public ManagedAppDataTransferLevelConstant? AllowedOutboundDataTransferDestinations { get; set; }

    [JsonPropertyName("appActionIfAccountIsClockedOut")]
    public ManagedAppRemediationActionConstant? AppActionIfAccountIsClockedOut { get; set; }

    [JsonPropertyName("appActionIfAndroidDeviceManufacturerNotAllowed")]
    public ManagedAppRemediationActionConstant? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }

    [JsonPropertyName("appActionIfAndroidDeviceModelNotAllowed")]
    public ManagedAppRemediationActionConstant? AppActionIfAndroidDeviceModelNotAllowed { get; set; }

    [JsonPropertyName("appActionIfAndroidSafetyNetAppsVerificationFailed")]
    public ManagedAppRemediationActionConstant? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }

    [JsonPropertyName("appActionIfAndroidSafetyNetDeviceAttestationFailed")]
    public ManagedAppRemediationActionConstant? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }

    [JsonPropertyName("appActionIfDeviceComplianceRequired")]
    public ManagedAppRemediationActionConstant? AppActionIfDeviceComplianceRequired { get; set; }

    [JsonPropertyName("appActionIfDeviceLockNotSet")]
    public ManagedAppRemediationActionConstant? AppActionIfDeviceLockNotSet { get; set; }

    [JsonPropertyName("appActionIfDevicePasscodeComplexityLessThanHigh")]
    public ManagedAppRemediationActionConstant? AppActionIfDevicePasscodeComplexityLessThanHigh { get; set; }

    [JsonPropertyName("appActionIfDevicePasscodeComplexityLessThanLow")]
    public ManagedAppRemediationActionConstant? AppActionIfDevicePasscodeComplexityLessThanLow { get; set; }

    [JsonPropertyName("appActionIfDevicePasscodeComplexityLessThanMedium")]
    public ManagedAppRemediationActionConstant? AppActionIfDevicePasscodeComplexityLessThanMedium { get; set; }

    [JsonPropertyName("appActionIfMaximumPinRetriesExceeded")]
    public ManagedAppRemediationActionConstant? AppActionIfMaximumPinRetriesExceeded { get; set; }

    [JsonPropertyName("appActionIfUnableToAuthenticateUser")]
    public ManagedAppRemediationActionConstant? AppActionIfUnableToAuthenticateUser { get; set; }

    [JsonPropertyName("appGroupType")]
    public TargetedManagedAppGroupTypeConstant? AppGroupType { get; set; }

    [JsonPropertyName("approvedKeyboards")]
    public List<KeyValuePairModel>? ApprovedKeyboards { get; set; }

    [JsonPropertyName("apps")]
    public List<ManagedMobileAppModel>? Apps { get; set; }

    [JsonPropertyName("assignments")]
    public List<TargetedManagedAppPolicyAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("biometricAuthenticationBlocked")]
    public bool? BiometricAuthenticationBlocked { get; set; }

    [JsonPropertyName("blockAfterCompanyPortalUpdateDeferralInDays")]
    public int? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }

    [JsonPropertyName("blockDataIngestionIntoOrganizationDocuments")]
    public bool? BlockDataIngestionIntoOrganizationDocuments { get; set; }

    [JsonPropertyName("connectToVpnOnLaunch")]
    public bool? ConnectToVpnOnLaunch { get; set; }

    [JsonPropertyName("contactSyncBlocked")]
    public bool? ContactSyncBlocked { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("customBrowserDisplayName")]
    public string? CustomBrowserDisplayName { get; set; }

    [JsonPropertyName("customBrowserPackageId")]
    public string? CustomBrowserPackageId { get; set; }

    [JsonPropertyName("customDialerAppDisplayName")]
    public string? CustomDialerAppDisplayName { get; set; }

    [JsonPropertyName("customDialerAppPackageId")]
    public string? CustomDialerAppPackageId { get; set; }

    [JsonPropertyName("dataBackupBlocked")]
    public bool? DataBackupBlocked { get; set; }

    [JsonPropertyName("deployedAppCount")]
    public int? DeployedAppCount { get; set; }

    [JsonPropertyName("deploymentSummary")]
    public ManagedAppPolicyDeploymentSummaryModel? DeploymentSummary { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deviceComplianceRequired")]
    public bool? DeviceComplianceRequired { get; set; }

    [JsonPropertyName("deviceLockRequired")]
    public bool? DeviceLockRequired { get; set; }

    [JsonPropertyName("dialerRestrictionLevel")]
    public ManagedAppPhoneNumberRedirectLevelConstant? DialerRestrictionLevel { get; set; }

    [JsonPropertyName("disableAppEncryptionIfDeviceEncryptionIsEnabled")]
    public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

    [JsonPropertyName("disableAppPinIfDevicePinIsSet")]
    public bool? DisableAppPinIfDevicePinIsSet { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("encryptAppData")]
    public bool? EncryptAppData { get; set; }

    [JsonPropertyName("exemptedAppPackages")]
    public List<KeyValuePairModel>? ExemptedAppPackages { get; set; }

    [JsonPropertyName("fingerprintAndBiometricEnabled")]
    public bool? FingerprintAndBiometricEnabled { get; set; }

    [JsonPropertyName("fingerprintBlocked")]
    public bool? FingerprintBlocked { get; set; }

    [JsonPropertyName("gracePeriodToBlockAppsDuringOffClockHours")]
    public string? GracePeriodToBlockAppsDuringOffClockHours { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isAssigned")]
    public bool? IsAssigned { get; set; }

    [JsonPropertyName("keyboardsRestricted")]
    public bool? KeyboardsRestricted { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("managedBrowser")]
    public ManagedBrowserTypeConstant? ManagedBrowser { get; set; }

    [JsonPropertyName("managedBrowserToOpenLinksRequired")]
    public bool? ManagedBrowserToOpenLinksRequired { get; set; }

    [JsonPropertyName("maximumAllowedDeviceThreatLevel")]
    public ManagedAppDeviceThreatLevelConstant? MaximumAllowedDeviceThreatLevel { get; set; }

    [JsonPropertyName("maximumPinRetries")]
    public int? MaximumPinRetries { get; set; }

    [JsonPropertyName("maximumRequiredOsVersion")]
    public string? MaximumRequiredOsVersion { get; set; }

    [JsonPropertyName("maximumWarningOsVersion")]
    public string? MaximumWarningOsVersion { get; set; }

    [JsonPropertyName("maximumWipeOsVersion")]
    public string? MaximumWipeOsVersion { get; set; }

    [JsonPropertyName("minimumPinLength")]
    public int? MinimumPinLength { get; set; }

    [JsonPropertyName("minimumRequiredAppVersion")]
    public string? MinimumRequiredAppVersion { get; set; }

    [JsonPropertyName("minimumRequiredCompanyPortalVersion")]
    public string? MinimumRequiredCompanyPortalVersion { get; set; }

    [JsonPropertyName("minimumRequiredOsVersion")]
    public string? MinimumRequiredOsVersion { get; set; }

    [JsonPropertyName("minimumRequiredPatchVersion")]
    public string? MinimumRequiredPatchVersion { get; set; }

    [JsonPropertyName("minimumWarningAppVersion")]
    public string? MinimumWarningAppVersion { get; set; }

    [JsonPropertyName("minimumWarningCompanyPortalVersion")]
    public string? MinimumWarningCompanyPortalVersion { get; set; }

    [JsonPropertyName("minimumWarningOsVersion")]
    public string? MinimumWarningOsVersion { get; set; }

    [JsonPropertyName("minimumWarningPatchVersion")]
    public string? MinimumWarningPatchVersion { get; set; }

    [JsonPropertyName("minimumWipeAppVersion")]
    public string? MinimumWipeAppVersion { get; set; }

    [JsonPropertyName("minimumWipeCompanyPortalVersion")]
    public string? MinimumWipeCompanyPortalVersion { get; set; }

    [JsonPropertyName("minimumWipeOsVersion")]
    public string? MinimumWipeOsVersion { get; set; }

    [JsonPropertyName("minimumWipePatchVersion")]
    public string? MinimumWipePatchVersion { get; set; }

    [JsonPropertyName("mobileThreatDefensePartnerPriority")]
    public MobileThreatDefensePartnerPriorityConstant? MobileThreatDefensePartnerPriority { get; set; }

    [JsonPropertyName("mobileThreatDefenseRemediationAction")]
    public ManagedAppRemediationActionConstant? MobileThreatDefenseRemediationAction { get; set; }

    [JsonPropertyName("notificationRestriction")]
    public ManagedAppNotificationRestrictionConstant? NotificationRestriction { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("organizationalCredentialsRequired")]
    public bool? OrganizationalCredentialsRequired { get; set; }

    [JsonPropertyName("periodBeforePinReset")]
    public string? PeriodBeforePinReset { get; set; }

    [JsonPropertyName("periodOfflineBeforeAccessCheck")]
    public string? PeriodOfflineBeforeAccessCheck { get; set; }

    [JsonPropertyName("periodOfflineBeforeWipeIsEnforced")]
    public string? PeriodOfflineBeforeWipeIsEnforced { get; set; }

    [JsonPropertyName("periodOnlineBeforeAccessCheck")]
    public string? PeriodOnlineBeforeAccessCheck { get; set; }

    [JsonPropertyName("pinCharacterSet")]
    public ManagedAppPinCharacterSetConstant? PinCharacterSet { get; set; }

    [JsonPropertyName("pinRequired")]
    public bool? PinRequired { get; set; }

    [JsonPropertyName("pinRequiredInsteadOfBiometricTimeout")]
    public string? PinRequiredInsteadOfBiometricTimeout { get; set; }

    [JsonPropertyName("previousPinBlockCount")]
    public int? PreviousPinBlockCount { get; set; }

    [JsonPropertyName("printBlocked")]
    public bool? PrintBlocked { get; set; }

    [JsonPropertyName("requireClass3Biometrics")]
    public bool? RequireClass3Biometrics { get; set; }

    [JsonPropertyName("requirePinAfterBiometricChange")]
    public bool? RequirePinAfterBiometricChange { get; set; }

    [JsonPropertyName("requiredAndroidSafetyNetAppsVerificationType")]
    public AndroidManagedAppSafetyNetAppsVerificationTypeConstant? RequiredAndroidSafetyNetAppsVerificationType { get; set; }

    [JsonPropertyName("requiredAndroidSafetyNetDeviceAttestationType")]
    public AndroidManagedAppSafetyNetDeviceAttestationTypeConstant? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }

    [JsonPropertyName("requiredAndroidSafetyNetEvaluationType")]
    public AndroidManagedAppSafetyNetEvaluationTypeConstant? RequiredAndroidSafetyNetEvaluationType { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("saveAsBlocked")]
    public bool? SaveAsBlocked { get; set; }

    [JsonPropertyName("screenCaptureBlocked")]
    public bool? ScreenCaptureBlocked { get; set; }

    [JsonPropertyName("simplePinBlocked")]
    public bool? SimplePinBlocked { get; set; }

    [JsonPropertyName("targetedAppManagementLevels")]
    public AppManagementLevelConstant? TargetedAppManagementLevels { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("warnAfterCompanyPortalUpdateDeferralInDays")]
    public int? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }

    [JsonPropertyName("wipeAfterCompanyPortalUpdateDeferralInDays")]
    public int? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }
}
