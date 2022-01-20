using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.AnalysisServices.v2017_08_01.Servers;


internal class AnalysisServicesServerUpdateParametersModel
{
    [JsonPropertyName("properties")]
    public AnalysisServicesServerMutablePropertiesModel? Properties { get; set; }

    [JsonPropertyName("sku")]
    public ResourceSkuModel? Sku { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }
}
