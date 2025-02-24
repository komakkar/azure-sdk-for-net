// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class VirtualMachineConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("imageReference");
            writer.WriteObjectValue(ImageReference);
            writer.WritePropertyName("nodeAgentSkuId");
            writer.WriteStringValue(NodeAgentSkuId);
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration");
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks");
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration");
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (Optional.IsDefined(DiskEncryptionConfiguration))
            {
                writer.WritePropertyName("diskEncryptionConfiguration");
                writer.WriteObjectValue(DiskEncryptionConfiguration);
            }
            if (Optional.IsDefined(NodePlacementConfiguration))
            {
                writer.WritePropertyName("nodePlacementConfiguration");
                writer.WriteObjectValue(NodePlacementConfiguration);
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions");
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk");
                writer.WriteObjectValue(OSDisk);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineConfiguration DeserializeVirtualMachineConfiguration(JsonElement element)
        {
            ImageReference imageReference = default;
            string nodeAgentSkuId = default;
            Optional<WindowsConfiguration> windowsConfiguration = default;
            Optional<IList<DataDisk>> dataDisks = default;
            Optional<string> licenseType = default;
            Optional<ContainerConfiguration> containerConfiguration = default;
            Optional<DiskEncryptionConfiguration> diskEncryptionConfiguration = default;
            Optional<NodePlacementConfiguration> nodePlacementConfiguration = default;
            Optional<IList<VmExtension>> extensions = default;
            Optional<OSDisk> osDisk = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"))
                {
                    imageReference = ImageReference.DeserializeImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeAgentSkuId"))
                {
                    nodeAgentSkuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataDisk> array = new List<DataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataDisk.DeserializeDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("licenseType"))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerConfiguration = ContainerConfiguration.DeserializeContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskEncryptionConfiguration = DiskEncryptionConfiguration.DeserializeDiskEncryptionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nodePlacementConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodePlacementConfiguration = NodePlacementConfiguration.DeserializeNodePlacementConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VmExtension> array = new List<VmExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmExtension.DeserializeVmExtension(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("osDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDisk = OSDisk.DeserializeOSDisk(property.Value);
                    continue;
                }
            }
            return new VirtualMachineConfiguration(imageReference, nodeAgentSkuId, windowsConfiguration.Value, Optional.ToList(dataDisks), licenseType.Value, containerConfiguration.Value, diskEncryptionConfiguration.Value, nodePlacementConfiguration.Value, Optional.ToList(extensions), osDisk.Value);
        }
    }
}
