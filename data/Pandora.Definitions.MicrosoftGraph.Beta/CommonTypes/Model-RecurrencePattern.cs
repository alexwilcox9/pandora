// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class RecurrencePatternModel
{
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    [JsonPropertyName("daysOfWeek")]
    public List<DayOfWeekConstant>? DaysOfWeek { get; set; }

    [JsonPropertyName("firstDayOfWeek")]
    public DayOfWeekConstant? FirstDayOfWeek { get; set; }

    [JsonPropertyName("index")]
    public WeekIndexConstant? Index { get; set; }

    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    [JsonPropertyName("month")]
    public int? Month { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("type")]
    public RecurrencePatternTypeConstant? Type { get; set; }
}
