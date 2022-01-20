using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.HcxEnterpriseSites;


internal class HcxEnterpriseSitePropertiesModel
{
    [JsonPropertyName("activationKey")]
    public string? ActivationKey { get; set; }

    [JsonPropertyName("status")]
    public HcxEnterpriseSiteStatusConstant? Status { get; set; }
}
