using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.GenerateDetailedCostReportOperationStatus;


internal class GenerateDetailedCostReportOperationStatusesModel
{
    [JsonPropertyName("error")]
    public ErrorDetailsModel? Error { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public DownloadURLModel? Properties { get; set; }

    [JsonPropertyName("status")]
    public StatusModel? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
