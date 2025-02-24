// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class FlowAccessControlConfigurationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedCallerIPAddresses))
            {
                writer.WritePropertyName("allowedCallerIpAddresses");
                writer.WriteStartArray();
                foreach (var item in AllowedCallerIPAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OpenAuthenticationPolicies))
            {
                writer.WritePropertyName("openAuthenticationPolicies");
                writer.WriteObjectValue(OpenAuthenticationPolicies);
            }
            writer.WriteEndObject();
        }

        internal static FlowAccessControlConfigurationPolicy DeserializeFlowAccessControlConfigurationPolicy(JsonElement element)
        {
            Optional<IList<IPAddressRange>> allowedCallerIpAddresses = default;
            Optional<OpenAuthenticationAccessPolicies> openAuthenticationPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedCallerIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddressRange> array = new List<IPAddressRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressRange.DeserializeIPAddressRange(item));
                    }
                    allowedCallerIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("openAuthenticationPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    openAuthenticationPolicies = OpenAuthenticationAccessPolicies.DeserializeOpenAuthenticationAccessPolicies(property.Value);
                    continue;
                }
            }
            return new FlowAccessControlConfigurationPolicy(Optional.ToList(allowedCallerIpAddresses), openAuthenticationPolicies.Value);
        }
    }
}
