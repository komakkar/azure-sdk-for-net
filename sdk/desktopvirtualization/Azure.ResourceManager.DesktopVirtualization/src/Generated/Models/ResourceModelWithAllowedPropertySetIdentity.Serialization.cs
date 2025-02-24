// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ResourceModelWithAllowedPropertySetIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceIdentityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ResourceIdentityType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ResourceModelWithAllowedPropertySetIdentity DeserializeResourceModelWithAllowedPropertySetIdentity(JsonElement element)
        {
            Optional<string> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<ResourceIdentityType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceIdentityType(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceModelWithAllowedPropertySetIdentity(principalId.Value, Optional.ToNullable(tenantId), Optional.ToNullable(type));
        }
    }
}
