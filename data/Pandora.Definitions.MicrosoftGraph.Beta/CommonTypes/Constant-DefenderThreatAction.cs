// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DefenderThreatActionConstant
{
    [Description("DeviceDefault")]
    @deviceDefault,

    [Description("Clean")]
    @clean,

    [Description("Quarantine")]
    @quarantine,

    [Description("Remove")]
    @remove,

    [Description("Allow")]
    @allow,

    [Description("UserDefined")]
    @userDefined,

    [Description("Block")]
    @block,
}
