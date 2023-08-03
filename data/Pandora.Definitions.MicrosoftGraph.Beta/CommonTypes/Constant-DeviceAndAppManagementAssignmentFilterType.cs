// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeviceAndAppManagementAssignmentFilterTypeConstant
{
    [Description("None")]
    @none,

    [Description("Include")]
    @include,

    [Description("Exclude")]
    @exclude,
}
