// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ResourceSku
    {
        internal static ResourceSku DeserializeResourceSku(JsonElement element)
        {
            Optional<SkuType> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = new SkuType(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceSku(Optional.ToNullable(name));
        }
    }
}
