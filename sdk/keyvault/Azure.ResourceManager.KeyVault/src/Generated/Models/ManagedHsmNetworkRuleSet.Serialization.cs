// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHsmNetworkRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Bypass))
            {
                writer.WritePropertyName("bypass");
                writer.WriteStringValue(Bypass.Value.ToString());
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction");
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules");
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedHsmNetworkRuleSet DeserializeManagedHsmNetworkRuleSet(JsonElement element)
        {
            Optional<ManagedHsmNetworkRuleBypassOption> bypass = default;
            Optional<NetworkRuleAction> defaultAction = default;
            Optional<IList<ManagedHsmIPRule>> ipRules = default;
            Optional<IList<ManagedHsmVirtualNetworkRule>> virtualNetworkRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bypass"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bypass = new ManagedHsmNetworkRuleBypassOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultAction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultAction = new NetworkRuleAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedHsmIPRule> array = new List<ManagedHsmIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmIPRule.DeserializeManagedHsmIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("virtualNetworkRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedHsmVirtualNetworkRule> array = new List<ManagedHsmVirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmVirtualNetworkRule.DeserializeManagedHsmVirtualNetworkRule(item));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
            }
            return new ManagedHsmNetworkRuleSet(Optional.ToNullable(bypass), Optional.ToNullable(defaultAction), Optional.ToList(ipRules), Optional.ToList(virtualNetworkRules));
        }
    }
}
