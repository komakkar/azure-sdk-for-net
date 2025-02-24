// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class NetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountAccess))
            {
                writer.WritePropertyName("accountAccess");
                writer.WriteObjectValue(AccountAccess);
            }
            if (Optional.IsDefined(NodeManagementAccess))
            {
                writer.WritePropertyName("nodeManagementAccess");
                writer.WriteObjectValue(NodeManagementAccess);
            }
            writer.WriteEndObject();
        }

        internal static NetworkProfile DeserializeNetworkProfile(JsonElement element)
        {
            Optional<EndpointAccessProfile> accountAccess = default;
            Optional<EndpointAccessProfile> nodeManagementAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountAccess = EndpointAccessProfile.DeserializeEndpointAccessProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeManagementAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeManagementAccess = EndpointAccessProfile.DeserializeEndpointAccessProfile(property.Value);
                    continue;
                }
            }
            return new NetworkProfile(accountAccess.Value, nodeManagementAccess.Value);
        }
    }
}
