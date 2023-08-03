// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FolderProtectionTypeConstant
{
    [Description("UserDefined")]
    @userDefined,

    [Description("Enable")]
    @enable,

    [Description("AuditMode")]
    @auditMode,

    [Description("BlockDiskModification")]
    @blockDiskModification,

    [Description("AuditDiskModification")]
    @auditDiskModification,
}
