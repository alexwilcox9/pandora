using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

namespace Pandora.Definitions.MicrosoftGraph.StableV1.ServicePrincipals.StableV1.ServicePrincipalSynchronizationTemplate;

internal class CreateSynchronizationTemplateOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(SynchronizationTemplateModel);
    public override ResourceID? ResourceId() => new ServicePrincipalId();
    public override Type? ResponseObject() => typeof(SynchronizationTemplateModel);
    public override string? UriSuffix() => "/synchronization/templates";
}
