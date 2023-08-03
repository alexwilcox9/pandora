// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AuditLogRootModel
{
    [JsonPropertyName("directoryAudits")]
    public List<DirectoryAuditModel>? DirectoryAudits { get; set; }

    [JsonPropertyName("directoryProvisioning")]
    public List<ProvisioningObjectSummaryModel>? DirectoryProvisioning { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("provisioning")]
    public List<ProvisioningObjectSummaryModel>? Provisioning { get; set; }

    [JsonPropertyName("signIns")]
    public List<SignInModel>? SignIns { get; set; }
}
