// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The upgrade mode of the cluster when new Service Fabric runtime version is available. </summary>
    public readonly partial struct UpgradeMode : IEquatable<UpgradeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpgradeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomaticValue = "Automatic";
        private const string ManualValue = "Manual";

        /// <summary> The cluster will be automatically upgraded to the latest Service Fabric runtime version, **upgradeWave** will determine when the upgrade starts after the new version becomes available. </summary>
        public static UpgradeMode Automatic { get; } = new UpgradeMode(AutomaticValue);
        /// <summary> The cluster will not be automatically upgraded to the latest Service Fabric runtime version. The cluster is upgraded by setting the **clusterCodeVersion** property in the cluster resource. </summary>
        public static UpgradeMode Manual { get; } = new UpgradeMode(ManualValue);
        /// <summary> Determines if two <see cref="UpgradeMode"/> values are the same. </summary>
        public static bool operator ==(UpgradeMode left, UpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(UpgradeMode left, UpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpgradeMode"/>. </summary>
        public static implicit operator UpgradeMode(string value) => new UpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
