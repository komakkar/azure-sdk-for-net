// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Type of verification. </summary>
    public readonly partial struct VerificationType : IEquatable<VerificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VerificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VerificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainValue = "Domain";
        private const string SpfValue = "SPF";
        private const string DkimValue = "DKIM";
        private const string Dkim2Value = "DKIM2";
        private const string DmarcValue = "DMARC";

        /// <summary> Domain. </summary>
        public static VerificationType Domain { get; } = new VerificationType(DomainValue);
        /// <summary> SPF. </summary>
        public static VerificationType Spf { get; } = new VerificationType(SpfValue);
        /// <summary> DKIM. </summary>
        public static VerificationType Dkim { get; } = new VerificationType(DkimValue);
        /// <summary> DKIM2. </summary>
        public static VerificationType Dkim2 { get; } = new VerificationType(Dkim2Value);
        /// <summary> DMARC. </summary>
        public static VerificationType Dmarc { get; } = new VerificationType(DmarcValue);
        /// <summary> Determines if two <see cref="VerificationType"/> values are the same. </summary>
        public static bool operator ==(VerificationType left, VerificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VerificationType"/> values are not the same. </summary>
        public static bool operator !=(VerificationType left, VerificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VerificationType"/>. </summary>
        public static implicit operator VerificationType(string value) => new VerificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VerificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VerificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
