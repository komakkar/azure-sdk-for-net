// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Redis.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RedisConfiguration))
            {
                writer.WritePropertyName("redisConfiguration");
                writer.WriteObjectValue(RedisConfiguration);
            }
            if (Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion");
                writer.WriteStringValue(RedisVersion);
            }
            if (Optional.IsDefined(EnableNonSslPort))
            {
                writer.WritePropertyName("enableNonSslPort");
                writer.WriteBooleanValue(EnableNonSslPort.Value);
            }
            if (Optional.IsDefined(ReplicasPerMaster))
            {
                writer.WritePropertyName("replicasPerMaster");
                writer.WriteNumberValue(ReplicasPerMaster.Value);
            }
            if (Optional.IsDefined(ReplicasPerPrimary))
            {
                writer.WritePropertyName("replicasPerPrimary");
                writer.WriteNumberValue(ReplicasPerPrimary.Value);
            }
            if (Optional.IsCollectionDefined(TenantSettings))
            {
                writer.WritePropertyName("tenantSettings");
                writer.WriteStartObject();
                foreach (var item in TenantSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShardCount))
            {
                writer.WritePropertyName("shardCount");
                writer.WriteNumberValue(ShardCount.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId");
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(StaticIP))
            {
                writer.WritePropertyName("staticIP");
                writer.WriteStringValue(StaticIP);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RedisData DeserializeRedisData(JsonElement element)
        {
            Optional<IList<string>> zones = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RedisCommonPropertiesRedisConfiguration> redisConfiguration = default;
            Optional<string> redisVersion = default;
            Optional<bool> enableNonSslPort = default;
            Optional<int> replicasPerMaster = default;
            Optional<int> replicasPerPrimary = default;
            Optional<IDictionary<string, string>> tenantSettings = default;
            Optional<int> shardCount = default;
            Optional<TlsVersion> minimumTlsVersion = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            RedisSku sku = default;
            Optional<string> subnetId = default;
            Optional<string> staticIP = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> hostName = default;
            Optional<int> port = default;
            Optional<int> sslPort = default;
            Optional<RedisAccessKeys> accessKeys = default;
            Optional<IReadOnlyList<SubResource>> linkedServers = default;
            Optional<IReadOnlyList<RedisInstanceDetails>> instances = default;
            Optional<IReadOnlyList<RedisPrivateEndpointConnectionData>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("redisConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            redisConfiguration = RedisCommonPropertiesRedisConfiguration.DeserializeRedisCommonPropertiesRedisConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableNonSslPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableNonSslPort = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerMaster"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicasPerMaster = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerPrimary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicasPerPrimary = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tenantSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            tenantSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shardCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shardCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minimumTlsVersion = new TlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            sku = RedisSku.DeserializeRedisSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subnetId"))
                        {
                            subnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("staticIP"))
                        {
                            staticIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sslPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("accessKeys"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessKeys = RedisAccessKeys.DeserializeRedisAccessKeys(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("linkedServers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.ToString()));
                            }
                            linkedServers = array;
                            continue;
                        }
                        if (property0.NameEquals("instances"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RedisInstanceDetails> array = new List<RedisInstanceDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisInstanceDetails.DeserializeRedisInstanceDetails(item));
                            }
                            instances = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RedisPrivateEndpointConnectionData> array = new List<RedisPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisPrivateEndpointConnectionData.DeserializeRedisPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RedisData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(zones), identity, redisConfiguration.Value, redisVersion.Value, Optional.ToNullable(enableNonSslPort), Optional.ToNullable(replicasPerMaster), Optional.ToNullable(replicasPerPrimary), Optional.ToDictionary(tenantSettings), Optional.ToNullable(shardCount), Optional.ToNullable(minimumTlsVersion), Optional.ToNullable(publicNetworkAccess), sku, subnetId.Value, staticIP.Value, Optional.ToNullable(provisioningState), hostName.Value, Optional.ToNullable(port), Optional.ToNullable(sslPort), accessKeys.Value, Optional.ToList(linkedServers), Optional.ToList(instances), Optional.ToList(privateEndpointConnections));
        }
    }
}
