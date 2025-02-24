// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Network policy used for building the Kubernetes network. </summary>
    public readonly partial struct NetworkPolicy : IEquatable<NetworkPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CalicoValue = "calico";
        private const string AzureValue = "azure";

        /// <summary> Use Calico network policies. See [differences between Azure and Calico policies](https://docs.microsoft.com/azure/aks/use-network-policies#differences-between-azure-and-calico-policies-and-their-capabilities) for more information. </summary>
        public static NetworkPolicy Calico { get; } = new NetworkPolicy(CalicoValue);
        /// <summary> Use Azure network policies. See [differences between Azure and Calico policies](https://docs.microsoft.com/azure/aks/use-network-policies#differences-between-azure-and-calico-policies-and-their-capabilities) for more information. </summary>
        public static NetworkPolicy Azure { get; } = new NetworkPolicy(AzureValue);
        /// <summary> Determines if two <see cref="NetworkPolicy"/> values are the same. </summary>
        public static bool operator ==(NetworkPolicy left, NetworkPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkPolicy"/> values are not the same. </summary>
        public static bool operator !=(NetworkPolicy left, NetworkPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkPolicy"/>. </summary>
        public static implicit operator NetworkPolicy(string value) => new NetworkPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
