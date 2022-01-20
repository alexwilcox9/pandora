using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.FrontDoors;


internal class BackendModel
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("backendHostHeader")]
    public string? BackendHostHeader { get; set; }

    [JsonPropertyName("enabledState")]
    public BackendEnabledStateConstant? EnabledState { get; set; }

    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("privateEndpointStatus")]
    public PrivateEndpointStatusConstant? PrivateEndpointStatus { get; set; }

    [JsonPropertyName("privateLinkAlias")]
    public string? PrivateLinkAlias { get; set; }

    [JsonPropertyName("privateLinkApprovalMessage")]
    public string? PrivateLinkApprovalMessage { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
