// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Applications.Beta.Application;

internal class AddApplicationKeyRequestModel
{
    [JsonPropertyName("keyCredential")]
    public KeyCredentialModel? KeyCredential { get; set; }

    [JsonPropertyName("passwordCredential")]
    public PasswordCredentialModel? PasswordCredential { get; set; }

    [JsonPropertyName("proof")]
    public string? Proof { get; set; }
}
