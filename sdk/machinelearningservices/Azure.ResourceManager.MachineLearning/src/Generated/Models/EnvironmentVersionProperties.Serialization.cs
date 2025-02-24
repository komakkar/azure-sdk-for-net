// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class EnvironmentVersionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Build))
            {
                writer.WritePropertyName("build");
                writer.WriteObjectValue(Build);
            }
            if (Optional.IsDefined(CondaFile))
            {
                writer.WritePropertyName("condaFile");
                writer.WriteStringValue(CondaFile);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(InferenceConfig))
            {
                writer.WritePropertyName("inferenceConfig");
                writer.WriteObjectValue(InferenceConfig);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous");
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived");
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static EnvironmentVersionProperties DeserializeEnvironmentVersionProperties(JsonElement element)
        {
            Optional<BuildContext> build = default;
            Optional<string> condaFile = default;
            Optional<EnvironmentType> environmentType = default;
            Optional<string> image = default;
            Optional<InferenceContainerProperties> inferenceConfig = default;
            Optional<OperatingSystemType> osType = default;
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("build"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    build = BuildContext.DeserializeBuildContext(property.Value);
                    continue;
                }
                if (property.NameEquals("condaFile"))
                {
                    condaFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environmentType = new EnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inferenceConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inferenceConfig = InferenceContainerProperties.DeserializeInferenceContainerProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = new OperatingSystemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isAnonymous"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new EnvironmentVersionProperties(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), build.Value, condaFile.Value, Optional.ToNullable(environmentType), image.Value, inferenceConfig.Value, Optional.ToNullable(osType));
        }
    }
}
