// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class OrganizationSettingsModel
{
    [JsonPropertyName("contactInsights")]
    public InsightsSettingsModel? ContactInsights { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("itemInsights")]
    public InsightsSettingsModel? ItemInsights { get; set; }

    [JsonPropertyName("microsoftApplicationDataAccess")]
    public MicrosoftApplicationDataAccessSettingsModel? MicrosoftApplicationDataAccess { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("peopleInsights")]
    public InsightsSettingsModel? PeopleInsights { get; set; }

    [JsonPropertyName("profileCardProperties")]
    public List<ProfileCardPropertyModel>? ProfileCardProperties { get; set; }

    [JsonPropertyName("pronouns")]
    public PronounsSettingsModel? Pronouns { get; set; }
}
