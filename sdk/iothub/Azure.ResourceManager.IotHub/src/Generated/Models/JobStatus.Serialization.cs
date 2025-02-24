// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    internal static partial class JobStatusExtensions
    {
        public static string ToSerialString(this JobStatus value) => value switch
        {
            JobStatus.Unknown => "unknown",
            JobStatus.Enqueued => "enqueued",
            JobStatus.Running => "running",
            JobStatus.Completed => "completed",
            JobStatus.Failed => "failed",
            JobStatus.Cancelled => "cancelled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobStatus value.")
        };

        public static JobStatus ToJobStatus(this string value)
        {
            if (string.Equals(value, "unknown", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Unknown;
            if (string.Equals(value, "enqueued", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Enqueued;
            if (string.Equals(value, "running", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Running;
            if (string.Equals(value, "completed", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Completed;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Failed;
            if (string.Equals(value, "cancelled", StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Cancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobStatus value.");
        }
    }
}
