// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Applications.StableV1.ApplicationSynchronizationJobSchemaDirectory;

internal class ListSchemaDirectoriesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new SynchronizationJobId();
    public override Type NestedItemType() => typeof(DirectoryDefinitionModel);
    public override string? UriSuffix() => "/schema/directories";
}
