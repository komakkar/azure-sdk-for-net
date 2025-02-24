// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </summary>
    internal partial class Diagnostics
    {
        /// <summary> Initializes a new instance of Diagnostics. </summary>
        internal Diagnostics()
        {
            Conditions = new ChangeTrackingList<DiagnosticCondition>();
        }

        /// <summary> Initializes a new instance of Diagnostics. </summary>
        /// <param name="conditions"> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </param>
        internal Diagnostics(IReadOnlyList<DiagnosticCondition> conditions)
        {
            Conditions = conditions;
        }

        /// <summary> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </summary>
        public IReadOnlyList<DiagnosticCondition> Conditions { get; }
    }
}
