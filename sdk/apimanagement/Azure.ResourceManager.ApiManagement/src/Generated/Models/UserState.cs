// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active. </summary>
    public readonly partial struct UserState : IEquatable<UserState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UserState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string BlockedValue = "blocked";
        private const string PendingValue = "pending";
        private const string DeletedValue = "deleted";

        /// <summary> User state is active. </summary>
        public static UserState Active { get; } = new UserState(ActiveValue);
        /// <summary> User is blocked. Blocked users cannot authenticate at developer portal or call API. </summary>
        public static UserState Blocked { get; } = new UserState(BlockedValue);
        /// <summary> User account is pending. Requires identity confirmation before it can be made active. </summary>
        public static UserState Pending { get; } = new UserState(PendingValue);
        /// <summary> User account is closed. All identities and related entities are removed. </summary>
        public static UserState Deleted { get; } = new UserState(DeletedValue);
        /// <summary> Determines if two <see cref="UserState"/> values are the same. </summary>
        public static bool operator ==(UserState left, UserState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserState"/> values are not the same. </summary>
        public static bool operator !=(UserState left, UserState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UserState"/>. </summary>
        public static implicit operator UserState(string value) => new UserState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
