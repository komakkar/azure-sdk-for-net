// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class AuthorizationMethodExtensions
    {
        public static string ToSerialString(this AuthorizationMethod value) => value switch
        {
            AuthorizationMethod.Head => "HEAD",
            AuthorizationMethod.Options => "OPTIONS",
            AuthorizationMethod.Trace => "TRACE",
            AuthorizationMethod.GET => "GET",
            AuthorizationMethod.Post => "POST",
            AuthorizationMethod.PUT => "PUT",
            AuthorizationMethod.Patch => "PATCH",
            AuthorizationMethod.Delete => "DELETE",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthorizationMethod value.")
        };

        public static AuthorizationMethod ToAuthorizationMethod(this string value)
        {
            if (string.Equals(value, "HEAD", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Head;
            if (string.Equals(value, "OPTIONS", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Options;
            if (string.Equals(value, "TRACE", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Trace;
            if (string.Equals(value, "GET", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.GET;
            if (string.Equals(value, "POST", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Post;
            if (string.Equals(value, "PUT", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.PUT;
            if (string.Equals(value, "PATCH", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Patch;
            if (string.Equals(value, "DELETE", StringComparison.InvariantCultureIgnoreCase)) return AuthorizationMethod.Delete;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AuthorizationMethod value.");
        }
    }
}
