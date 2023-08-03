// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum WindowsArchitectureConstant
{
    [Description("None")]
    @none,

    [Description("X86")]
    @x86,

    [Description("X64")]
    @x64,

    [Description("Arm")]
    @arm,

    [Description("Neutral")]
    @neutral,
}
