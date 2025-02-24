// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DiskList
    {
        internal static DiskList DeserializeDiskList(JsonElement element)
        {
            IReadOnlyList<ManagedDiskData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ManagedDiskData> array = new List<ManagedDiskData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedDiskData.DeserializeManagedDiskData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DiskList(value, nextLink.Value);
        }
    }
}
