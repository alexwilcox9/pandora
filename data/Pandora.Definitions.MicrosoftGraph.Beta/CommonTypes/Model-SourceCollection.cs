// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class SourceCollectionModel
{
    [JsonPropertyName("addToReviewSetOperation")]
    public AddToReviewSetOperationModel? AddToReviewSetOperation { get; set; }

    [JsonPropertyName("additionalSources")]
    public List<DataSourceModel>? AdditionalSources { get; set; }

    [JsonPropertyName("contentQuery")]
    public string? ContentQuery { get; set; }

    [JsonPropertyName("createdBy")]
    public IdentitySetModel? CreatedBy { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("custodianSources")]
    public List<DataSourceModel>? CustodianSources { get; set; }

    [JsonPropertyName("dataSourceScopes")]
    public DataSourceScopesConstant? DataSourceScopes { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastEstimateStatisticsOperation")]
    public EstimateStatisticsOperationModel? LastEstimateStatisticsOperation { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public IdentitySetModel? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("noncustodialSources")]
    public List<NoncustodialDataSourceModel>? NoncustodialSources { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
