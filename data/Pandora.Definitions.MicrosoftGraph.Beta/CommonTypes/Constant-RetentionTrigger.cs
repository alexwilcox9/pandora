// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RetentionTriggerConstant
{
    [Description("DateLabeled")]
    @dateLabeled,

    [Description("DateCreated")]
    @dateCreated,

    [Description("DateModified")]
    @dateModified,

    [Description("DateOfEvent")]
    @dateOfEvent,
}
