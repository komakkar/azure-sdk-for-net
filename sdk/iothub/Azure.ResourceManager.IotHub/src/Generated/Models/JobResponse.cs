// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the Job Response object. </summary>
    public partial class JobResponse
    {
        /// <summary> Initializes a new instance of JobResponse. </summary>
        internal JobResponse()
        {
        }

        /// <summary> Initializes a new instance of JobResponse. </summary>
        /// <param name="jobId"> The job identifier. </param>
        /// <param name="startTimeUtc"> The start time of the job. </param>
        /// <param name="endTimeUtc"> The time the job stopped processing. </param>
        /// <param name="jobType"> The type of the job. </param>
        /// <param name="status"> The status of the job. </param>
        /// <param name="failureReason"> If status == failed, this string containing the reason for the failure. </param>
        /// <param name="statusMessage"> The status message for the job. </param>
        /// <param name="parentJobId"> The job identifier of the parent job, if any. </param>
        internal JobResponse(string jobId, DateTimeOffset? startTimeUtc, DateTimeOffset? endTimeUtc, JobType? jobType, JobStatus? status, string failureReason, string statusMessage, string parentJobId)
        {
            JobId = jobId;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            JobType = jobType;
            Status = status;
            FailureReason = failureReason;
            StatusMessage = statusMessage;
            ParentJobId = parentJobId;
        }

        /// <summary> The job identifier. </summary>
        public string JobId { get; }
        /// <summary> The start time of the job. </summary>
        public DateTimeOffset? StartTimeUtc { get; }
        /// <summary> The time the job stopped processing. </summary>
        public DateTimeOffset? EndTimeUtc { get; }
        /// <summary> The type of the job. </summary>
        public JobType? JobType { get; }
        /// <summary> The status of the job. </summary>
        public JobStatus? Status { get; }
        /// <summary> If status == failed, this string containing the reason for the failure. </summary>
        public string FailureReason { get; }
        /// <summary> The status message for the job. </summary>
        public string StatusMessage { get; }
        /// <summary> The job identifier of the parent job, if any. </summary>
        public string ParentJobId { get; }
    }
}
