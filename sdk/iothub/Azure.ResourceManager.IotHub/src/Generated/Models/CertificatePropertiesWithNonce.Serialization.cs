// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class CertificatePropertiesWithNonce
    {
        internal static CertificatePropertiesWithNonce DeserializeCertificatePropertiesWithNonce(JsonElement element)
        {
            Optional<string> subject = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<string> thumbprint = default;
            Optional<bool> isVerified = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<string> verificationCode = default;
            Optional<string> certificate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("updated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("verificationCode"))
                {
                    verificationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
            }
            return new CertificatePropertiesWithNonce(subject.Value, Optional.ToNullable(expiry), thumbprint.Value, Optional.ToNullable(isVerified), Optional.ToNullable(created), Optional.ToNullable(updated), verificationCode.Value, certificate.Value);
        }
    }
}
