// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SimulationContentStatusConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Draft")]
    @draft,

    [Description("Ready")]
    @ready,

    [Description("Archive")]
    @archive,

    [Description("Delete")]
    @delete,
}
